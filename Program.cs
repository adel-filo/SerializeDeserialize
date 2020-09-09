using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string JSONresult = JsonConvert.SerializeObject(emp);
            string path = @"C:\Users\Adel\Desktop\.Net\SerializeDeserialize\Employee.json";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }

            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
        }
    }
}
