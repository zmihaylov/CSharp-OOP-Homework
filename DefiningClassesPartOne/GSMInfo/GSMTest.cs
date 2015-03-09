namespace GSMInfo
{
    using System;
    public class GSMTest
    {
        // Task 7
        public static void TestClassGSM(int numberOfTest)
        {
            GSM[] mobilePhones = new GSM[numberOfTest];

            for (int i = 0; i < numberOfTest; i++)
            {
                mobilePhones[i] = new GSM("Test model " + (i + 1), "Test manufacturer " + (i + 1), (i + 1) * 100, "Test owner " + (i + 1));
                mobilePhones[i].battery = new Battery("Battery test " + (i + 1), (i + 1) * (i + 1), (i + 2) * (i + 2), BatteryType.NiMH);
                mobilePhones[i].display = new Display((i + 1) * 0.5, (i + 1) * 64000);
                Console.WriteLine(mobilePhones[i]);
            }

            GSM myIPhone = new GSM("some", "some");
            Console.WriteLine(myIPhone.IPhone4S);
        }
    }
}
