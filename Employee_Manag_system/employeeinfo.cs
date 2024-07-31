using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manag_system
{
    public class employeeinfo
    {
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public int EmployeeSalry {get;set;}


        public double EmployeeGroth
        {
            get
            {
                return (EmployeeSalry+(EmployeeSalry*0.10));
            }
        }
    }
}
