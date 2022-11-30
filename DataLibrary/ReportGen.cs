using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class ReportGen:Database
    {
        public DataTable paymentReport(string startDate, string endDate)
        {
            return GetData($"SELECT * FROM `paymenthistory` WHERE (date BETWEEN '{startDate}' AND '{endDate}') ");
        }
    }
}
