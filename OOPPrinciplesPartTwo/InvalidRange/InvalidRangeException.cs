namespace InvalidRange
{
    using System;

    public class InvalidRangeException<T> : Exception where T : IComparable
    {

        public T MinValue { get; private set; }
        public T MaxValue { get; private set; }
        public string Message { get; private set; }

        public InvalidRangeException()
        {
            this.MinValue = this.GetMinValue();
            this.MaxValue = this.GetMaxValue();
            this.Message = String.Format("Valid values must be in the range: {0} and {1}", GetMinValue(), GetMaxValue());
        }
        private T GetMinValue()
        {
            if (typeof(T) == typeof(int))
            {
                return (T)Convert.ChangeType(1, typeof(Int32));
            }
            else if (typeof(T) == typeof(DateTime))
            {
                return (T)Convert.ChangeType(new DateTime(1980, 1, 1), typeof(DateTime));
            }
            else
            {
                throw new ArgumentException("A valid range for the minimum value is not set");
            }
        }

        private T GetMaxValue()
        {
            if (typeof(T) == typeof(int))
            {
                return (T)Convert.ChangeType(100, typeof(Int32));
            }
            else if (typeof(T) == typeof(DateTime))
            {
                return (T)Convert.ChangeType(new DateTime(2013, 12, 31), typeof(DateTime));
            }
            else
            {
                throw new ArgumentException("A valid range for the maximum value is not set");
            }
        }
    }
}
