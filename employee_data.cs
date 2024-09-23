using employee_details_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace employees
{
   public class employee_data
    {
        string emp_name;
        string emp_place;
        string emp_age;
        int emp_code;
        string emp_department;
        string emp_salary;


        public void emp_personal_details()
        {
            Console.WriteLine("enter employee name");
            emp_name = Console.ReadLine();
            Console.WriteLine("enter employee age");
            emp_age = Console.ReadLine();
            Console.WriteLine("enter employee place");
            emp_place = Console.ReadLine();

        }
        public void employee_oficial_details()
        {
            Console.WriteLine("enter employee code");
            emp_code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee department");
            emp_department = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            emp_salary = Console.ReadLine();
        }
        public void display_employee_fulldetails()
        {
            Console.WriteLine("Name: " + emp_name);
            Console.WriteLine("Age: " + emp_age);
            Console.WriteLine("Place: " + emp_place);
            Console.WriteLine("Code: " + emp_code);
            Console.WriteLine("Department: " + emp_department);
            Console.WriteLine("Salary: " + emp_salary);
        }
        public void department_details()
        {
            departments dp = new departments();
            dp.department_details(emp_name, emp_code);
            Console.ReadLine();
        }



    }
}
