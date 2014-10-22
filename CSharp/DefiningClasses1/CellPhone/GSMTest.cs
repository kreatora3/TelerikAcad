using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    class GSMTest
    {
        public static void PhoneTest()
        {
            GSM[] array = new GSM[3];
            array[0] = new GSM("N95", "Nokia", "[unknown]", 100, new Battery("BT12", BatteryType.LiIon, 300, 7), new Display(3.2, 65000));
            array[1] = new GSM("some model", "HTC", "Gosho", 345, new Battery("Bf12", BatteryType.LiIon, 255, 8), new Display(4.2, 65000));
            array[2] = new GSM("Bold", "BlackBerry", "Borko", 982, new Battery("TET2", BatteryType.NiCd, 500, 9), new Display(5.2, 65000));

            foreach (var gsm in array)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine(GSM.IPhone4S);

            Console.WriteLine();
        }
    }
}
