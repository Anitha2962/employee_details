using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using employees;
using employee_details_new;
using System.Threading.Tasks;


namespace employee_details
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                employee_data e = new employee_data();
                e.emp_personal_details();
                e.employee_oficial_details();
                e.display_employee_fulldetails();
                Console.ReadLine();

            }
        }
    }


