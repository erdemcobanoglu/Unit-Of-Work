using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Report
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        #region EklemelerRapor
        public int AnalystID { get; set; }  //gönderen
        public Employee EmployeeAnalyst { get; set; } 
        #endregion


    }
}
