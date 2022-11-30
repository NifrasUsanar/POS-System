using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class frmBackup : Form
    {
        bool isBackup = true;
        BackgroundWorker bw = new BackgroundWorker();
        bool hasError = false;
        string errmsg = "";
        string constr = "";
        string folder = "";
        int count = 0;
        DateTime timeProcessStart = DateTime.Now;

        public frmBackup()
        {
            InitializeComponent();

            bw.WorkerReportsProgress = true;
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.ProgressChanged += Bw_ProgressChanged;
        }

        bool LoadData()
        {
            GC.Collect();
            hasError = false;
            errmsg = "";
            folder = txtBackup.Text;
            constr =Connection.connectionString;
            count = 0;
            timeProcessStart = DateTime.Now;
            txtProgress.Text = "Start at " + timeProcessStart.ToString("yyyy-MM-dd HH:mm:ss ffff") + "\r\n\r\n";
            this.Refresh();

            if (constr.Length == 0)
            {
                MessageBox.Show("Connection string is not set. Cannot continue.");
                return false;
            }

            return true;
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtProgress.AppendText(e.UserState + "");
            txtProgress.Select(txtProgress.Text.Length - 1, 0);
            txtProgress.ScrollToCaret();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime timeProcessEnd = DateTime.Now;

            var timeTotal = timeProcessEnd - timeProcessStart;

            this.SuspendLayout();

            txtProgress.Text = txtProgress.Text + "\r\nProcess End at " + timeProcessEnd.ToString("yyyy-MM-dd HH:mm:ss ffff") + "\r\n\r\nTotal time elapsed: " + string.Format("{0} h {1} m {2} s {3} ms", timeTotal.Hours, timeTotal.Minutes, timeTotal.Seconds, timeTotal.Milliseconds);

            if (hasError)
            {
                txtProgress.AppendText("\r\nError:\r\n\r\n");
                txtProgress.AppendText(errmsg);
            }

            txtProgress.Select(txtProgress.Text.Length - 1, 0);
            txtProgress.ScrollToCaret();

            this.ResumeLayout();
            this.PerformLayout();

            if (isBackup)
                MessageBox.Show($"{count} database exported at\r\n\r\n{txtBackup.Text}");
            else
                MessageBox.Show($"{count} database imported from\r\n\r\n{txtRestore.Text}");
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (isBackup)
                    DoBackup();
                else
                    DoRestore();
            }
            catch (Exception ex)
            {
                hasError = true;
                errmsg = ex.ToString();
            }
        }

        void DoRestore()
        {
            string file = txtRestore.Text;

            DateTime timeProcessStart = DateTime.Now;

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    //string db = Path.GetFileNameWithoutExtension(file);
                    string db = Global.database;

                    DateTime dateStart = DateTime.Now;

                    string appendText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  Restore " + db + "....";
                    bw.ReportProgress(0, appendText);

                    cmd.CommandText = "create database if not exists `" + db + "`";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"use `{db}`";
                    cmd.ExecuteNonQuery();

                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        mb.ImportFromFile(file);
                    }

                    DateTime dateEnd = DateTime.Now;

                    var timeElapsed = dateEnd - dateStart;

                    appendText = $" completed ({timeElapsed.Hours} h {timeElapsed.Minutes} m {timeElapsed.Seconds} s {timeElapsed.Milliseconds} ms)\r\n";
                    bw.ReportProgress(0, appendText);
                    count++;
                    conn.Close();
                }
            }
        }

        void DoBackup()
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    DataTable dt = GetTable(cmd, "show databases;");

                    foreach (DataRow dr in dt.Rows)
                    {
                        string db = dr[0] + "";
                        if (db == Global.database)
                        {
                            switch (db)
                            {
                                case "sys":
                                case "performance_schema":
                                case "mysql":
                                case "information_schema":
                                    continue;
                            }

                            DateTime dateStart = DateTime.Now;

                            string appendText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  Backup " + db + "....";
                            bw.ReportProgress(0, appendText);

                            cmd.CommandText = $"use `{db}`";
                            cmd.ExecuteNonQuery();

                            string file = Path.Combine(txtBackup.Text, $"{db}.iPOS");

                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                mb.ExportInfo.ExportTableStructure = true;
                                mb.ExportInfo.ExportRows = true;
                                mb.ExportToFile(file);
                            }

                            DateTime dateEnd = DateTime.Now;

                            var timeElapsed = dateEnd - dateStart;

                            appendText = $" completed ({timeElapsed.Hours} h {timeElapsed.Minutes} m {timeElapsed.Seconds} s {timeElapsed.Milliseconds} ms)" + "\r\n";
                            bw.ReportProgress(0, appendText);

                            count++;
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = fb.SelectedPath;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "POS Data Files (*.iPOS, *.sql)|*.iPOS;*.sql";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = opfd.FileName;
                txtProgress.Text = Path.GetDirectoryName(opfd.FileName);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtBackup.Text.Length == 0)
            {
                MessageBox.Show("Folder is not set");
                return;
            }

            if (!Directory.Exists(txtBackup.Text))
            {
                MessageBox.Show("Selected folder is not existed.");
                return;
            }

            isBackup = true;

            if (!LoadData())
            {
                return;
            }

            bw.RunWorkerAsync();
        }

        DataTable GetTable(MySqlCommand cmd, string sql)
        {
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtRestore.Text.Length == 0)
            {
                MessageBox.Show("Folder is not set");
                return;
            }

            if (!File.Exists(txtRestore.Text))
            {
                MessageBox.Show("Selected folder is not existed.");
                return;
            }

            isBackup = false;

            if (!LoadData())
            {
                return;
            }

            bw.RunWorkerAsync();
        }
    }
}
