using Employee_Manag_system;

employeemanage employeemanage = new employeemanage();

int choise = 1;

while (choise > 0)
{
    employeeinfo employeeinfo = new employeeinfo();
    Console.WriteLine("enter your choise");
    Console.WriteLine("1 for enter data");
    Console.WriteLine("2 for Display data");
    int num = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
        case 1:
  

    Console.WriteLine("enter employee name");
    employeeinfo.EmployeeName = Console.ReadLine();

    Console.WriteLine("enter employee ID");
    employeeinfo.EmployeeID = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter employee salry");
    employeeinfo.EmployeeSalry = Convert.ToInt32(Console.ReadLine());

    employeemanage.addemp(employeeinfo);
    
    break;

     case 2:

        employeemanage.display();
            choise = 0;

        break;
    }

}