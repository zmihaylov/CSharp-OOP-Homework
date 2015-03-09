namespace GSMInfo
{
    using System;
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedNumber;
        private ulong duaration;

        public Call(DateTime date,DateTime time,string dialedNumber,ulong duaration)
        {
            this.date = date;
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duaration = duaration;
        }

        public DateTime DateOfCall
        {
            get { return this.date; }
        }

        public DateTime TimeOfCall
        {
            get { return this.time; }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
        }

        public ulong Duration
        {
            get { return this.duaration; }
        }
    }
}
