using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_Free_Zone
{
    internal class UserManagement
    {
        public static void Admin()
        {
            string permission = "Admin|Manager";
            int level = 55;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("welcome super admin");
                }
                else
                {
                    Console.WriteLine("welcome admin");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("welcome manager");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}
