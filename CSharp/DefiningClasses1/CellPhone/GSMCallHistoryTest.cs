
namespace CellPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            // Creating instsance of GSM class
            GSM testPhone = new GSM("Nokia", "N90", "Kolio", 555);

            // Adding some calls 
            testPhone.AddCalls(new Call(DateTime.Now, "9999999", 334));
            testPhone.AddCalls(new Call(new DateTime(2014, 2, 21, 12, 22, 22), "888888", 220));
            testPhone.AddCalls(new Call(DateTime.Today, "77777777", 160));
            testPhone.AddCalls(new Call(DateTime.UtcNow, "666666666", 456));

            // Printing the call history
            testPhone.PrintCallHistory();

            // Calculating the current bill
            decimal phoneBill = testPhone.PhoneBill();
            Console.WriteLine("Your current phone bill is {0:C}", phoneBill);

            // Removing the call with the longest duration

            int maxDuration = int.MinValue;
            int callToRemove = 0;

            for (int i = 0; i < testPhone.CallHistory.Count; i++)
            {
                if (testPhone.CallHistory[i].Duration > maxDuration)
                {
                    maxDuration = testPhone.CallHistory[i].Duration;
                    callToRemove = i;
                }
            }

            testPhone.DeleteCall(callToRemove);
            Console.WriteLine();
           
            // Recalculating the phone bill

            phoneBill = testPhone.PhoneBill();
            Console.WriteLine("Your new phone bill is {0:C}", phoneBill);
            Console.WriteLine();

            // Clearing the history

            testPhone.ClearHistory();

            // Printing the cleared /empty/ call history
            testPhone.PrintCallHistory();

            Console.WriteLine();
        }
    }
}
