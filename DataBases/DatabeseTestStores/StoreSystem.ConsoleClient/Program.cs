using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Data;
using StoreSystem.Model;
using Newtonsoft.Json;
using System.IO;

namespace StoreSystem.ConsoleClient
{
    public class Program
    {
        public static string ReportFolder = "../../JsonReports/";
        public static string FileName = "{0}.json";
        static void Main()
        {
            var db = new StoreSystemDbContext();
            
            var employee = new Employee
            {
                FirstName = "Pesho",
                LastName = "Petrov"
            };

            db.Employees.Add(employee);
            var report = db.Employees;

            foreach (var item in report)
            {
                var employeeId = item.Id;
                var firstname = item.FirstName;
                var lasname = item.LastName;

                GenerateJson(employeeId, firstname, lasname);

            }
            
            db.SaveChanges();


        }

        public static void GenerateJson(int id, string firstName, string lastName)
        {
            object dataForReport = new
            {
                Id = id,
                FirstName = firstName,
                lastName = lastName
            };

            JsonSerializer serializer = new JsonSerializer();
            string employeeAsJson = JsonConvert.SerializeObject(dataForReport, Formatting.Indented);
           
            if (!Directory.Exists(ReportFolder))
            {
                Directory.CreateDirectory(ReportFolder);
            }

            StreamWriter writer = new StreamWriter(ReportFolder + string.Format(FileName, id.ToString()));
            using (writer)
            {
                writer.WriteLine(employeeAsJson);
            }
        }
    }
}
