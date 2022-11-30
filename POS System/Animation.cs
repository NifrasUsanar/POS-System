using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace POS_System
{
    class Animation
    {
        public static Panel pnlContent;
        public static Panel pnlContainer;
        public static Control pnlMenu;
        public static bool is_menu_active = false;
        public static Form parentForm;
        public static Control formTitle;

        public static void changeContent(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(usercontrol);

            //pnlMenu.Visible = false;
            menuTransition();
            is_menu_active = !is_menu_active;
        }

        public static void changeContentOnly(UserControl usercontrol)
        {
            pnlContent.Width = pnlContainer.Width;
            pnlContent.Height = pnlContainer.Height;
            pnlMenu.Width = pnlContent.Width;
            pnlMenu.Height = pnlContent.Height;

            if (pnlMenu.Top == 0)
            {
                changeContent(usercontrol);
            }
            else
            {
                Transition trsn = new Transition(new TransitionType_CriticalDamping(500));
                pnlContent.Top = pnlContent.Height;
                usercontrol.Dock = DockStyle.Fill;

                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(usercontrol);

                trsn.add(pnlContent, "Top", 0);
                trsn.run();
            }
        }

        public static void menuTransition()
        {
            Transition trsn = new Transition(new TransitionType_CriticalDamping(500));
            if (pnlMenu.Top == 0)
            {
                trsn.add(pnlContent, "Top", 0);             
                trsn.add(pnlMenu, "Top", pnlContent.Height);
            }
            else
            {
                trsn.add(pnlContent,"Top",pnlContent.Height);
                trsn.add(pnlMenu,"Top", 0); 
            }
            trsn.run();
        }

        public static void showModal(Form modalForm)
        {
            Form formBackground = new Form();
            try
            {
                using (modalForm)
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.BringToFront();
                    //formBackground.TopLevel = false;
                    //parentForm.Controls.Add(formBackground);
                    formBackground.Show();

                    modalForm.StartPosition = FormStartPosition.CenterParent;
                    modalForm.TopMost = true;
                    modalForm.Owner = formBackground;
                    modalForm.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
        public static DialogResult resultModal(Form modalForm)
        {
            Form formBackground = new Form();
            
            try
            {
                using (modalForm)
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.BringToFront();
                    formBackground.Show();

                    modalForm.StartPosition = FormStartPosition.CenterParent;
                    modalForm.TopMost = true;
                    modalForm.Owner = formBackground;
                    var result = modalForm.ShowDialog();
                    
                    formBackground.Dispose();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return DialogResult.None;
            }
            finally
            {
                formBackground.Dispose();
            }
        }


        public static void showListModal(Form modalForm)
        {
            Form formBackground = new Form();
            try
            {
                using (modalForm)
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .25d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.BringToFront();
                    //formBackground.TopLevel = false;
                    //parentForm.Controls.Add(formBackground);
                    formBackground.Show();

                    modalForm.TopMost = true;
                    modalForm.Owner = formBackground;
                    modalForm.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        //Show Message Box
        public static void showMessage(string message, string messageType)
        {            
            frmAlert alert = new frmAlert();
            alert.TopMost = true;
            alert.BringToFront();
            if (messageType == "success") alert.showAlert(message, frmAlert.enmType.Success);
            else if (messageType == "warning") alert.showAlert(message, frmAlert.enmType.Warning);
            else if (messageType == "info") alert.showAlert(message, frmAlert.enmType.Info);
            else if (messageType == "error") alert.showAlert(message, frmAlert.enmType.Error);
        }

        public static void showSideModal(Form modalForm)
        {
            Form formBackground = new Form();
            try
            {
                using (modalForm)
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.BringToFront();
                    //formBackground.TopLevel = false;
                    //parentForm.Controls.Add(formBackground);
                    formBackground.Show();

                    modalForm.StartPosition = FormStartPosition.Manual;

                    //Get screen resolution
                    Rectangle res = Screen.PrimaryScreen.Bounds;
                    modalForm.Height = formBackground.Height;
                    modalForm.Location = new Point(res.Width-modalForm.Width);
                    modalForm.TopMost = true;
                    modalForm.Owner = formBackground;
                    modalForm.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        public static void animateBottomText(bool flag)
        {
            if(flag==true)
            Transition.run(Global.lblWelcome, "Text", ("Developed By: IMS Software Solution - (0772585768)").ToUpper(), new TransitionType_Linear(1000));
            else Transition.run(Global.lblWelcome, "Text", Global.welcomeMessage.ToUpper(), new TransitionType_Linear(1000));
        }
    }
}
