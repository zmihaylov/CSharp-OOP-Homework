using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMInfo
{
    class GSMMain
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number of tests to perform:");
                int numberOfTests = int.Parse(Console.ReadLine());

                GSMTest.TestClassGSM(numberOfTests);
                Console.WriteLine();

                CallHisoryTest.GSMCallHistory(numberOfTests);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
