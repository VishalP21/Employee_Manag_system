using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manag_system
{
    public class employeemanage
    {
        List<employeeinfo> employeeinfos;

        public employeemanage()
        {
            employeeinfos = new List<employeeinfo>();
        }

        public void addemp(employeeinfo einfo)
        {
            employeeinfos.Add(einfo);
        }
        public void display()
        {
            foreach(employeeinfo info in employeeinfos)
            {
                Console.WriteLine("******");
                Console.WriteLine(info.EmployeeName);
                Console.WriteLine(info.EmployeeID);
                Console.WriteLine(info.EmployeeSalry);
                Console.WriteLine(info.EmployeeGroth);
            }
        }
    }
}
