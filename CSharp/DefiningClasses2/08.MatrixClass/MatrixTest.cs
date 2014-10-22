using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MatrixClass
{
    class MatrixTest
    {
        static void Main(string[] args)
        {

            Matrix<int> checkOne = new Matrix<int>(2, 2);
            checkOne[0, 0] = 1;
            checkOne[0, 1] = 2;
            checkOne[1, 0] = 3;
            checkOne[1, 1] = 4;
            

            Matrix<int> checkTwo = new Matrix<int>(2, 2);
            checkTwo[0, 0] = 9;
            checkTwo[0, 1] = 8;
            checkTwo[1, 0] = 7;
            checkTwo[1, 1] = 6;

            Console.WriteLine(checkOne + checkTwo);
            Console.WriteLine();

            Console.WriteLine(checkOne - checkTwo);
            Console.WriteLine();

            Console.WriteLine(checkOne * checkTwo);
            Console.WriteLine();
        }
    }
}
