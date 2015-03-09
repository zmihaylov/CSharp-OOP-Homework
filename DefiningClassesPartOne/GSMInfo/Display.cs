namespace GSMInfo
{
    using System;
    public class Display
    {
        // Task 1
        private double? size;
        private int? colors;

        // Task 2

        public Display()
            : this(null, null)
        {

        }
        public Display(int? size)
            : this(size, null)
        {

        }
        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.Colors = numberOfColors;
        }

        // Task 5

        public int? Colors
        {
            get { return this.colors; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of colors!");
                }
                this.colors = value;
            }
        }
        public double? Size
        {
            get { return this.size; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid size!");
                }
                this.size = value;
            }
        }
    }
}
