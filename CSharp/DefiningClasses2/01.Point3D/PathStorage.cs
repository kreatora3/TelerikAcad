using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3d
{
    /*04.Create a static class PathStorage with static methods to save and load paths from a text file.
     Use a file format of your choice.*/
    public static class PathStorage
    {
       
        public static void Save(Path somePath)
        {
            StreamWriter save = new StreamWriter("path.txt");

            using (save)
            {
                foreach (var point  in somePath.PointSeq)
                {
                    save.WriteLine(point);
                }
            }
        }

        public static void Load(string fileName)
        {
            StreamReader output = new StreamReader(fileName);

            string print = output.ReadLine();

            while (print != null)
            {
                Console.WriteLine(print);
                print = output.ReadLine();
            }
        }
    }
}
