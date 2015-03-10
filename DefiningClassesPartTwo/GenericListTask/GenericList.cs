namespace GenericListTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private T[] genericList;
        private int index;

        public GenericList(int size)
        {
            this.genericList = new T[size];
            this.index = 0;
        }

        public T this[int position]
        {
            get
            {
                CheckIfPositionIsCorrect(position);
                if (index - 1 < position)
                {
                    throw new ArgumentOutOfRangeException("Index was out of range");
                }
                return this.genericList[position];
            }
            set
            {
                CheckIfPositionIsCorrect(position);
                this.genericList[position] = value;
            }
        }

        public void Add(T element)
        {
            if (this.index == this.genericList.Length - 1)
            {
                AutoDoubleSize();
            }
            this.genericList[index] = element;
            this.index++;
        }

        public void RemoveAt(int position)
        {
            CheckIfPositionIsCorrect(position);
            T[] newList = new T[this.genericList.Length - 1];
            this.index--;
            Array.Copy(this.genericList, 0, newList, 0, position);
            Array.Copy(this.genericList, position + 1, newList, position, this.genericList.Length - 1 - position);
            this.genericList = newList;
        }

        public void InsertAt(T element, int position)
        {
            CheckIfPositionIsCorrect(position);
            T[] newList = new T[this.genericList.Length + 1];
            this.index++;
            Array.Copy(this.genericList, 0, newList, 0, position);
            newList[position] = element;
            Array.Copy(this.genericList, position, newList, position + 1, this.genericList.Length - position);
            this.genericList = newList;
        }

        public int Find(T element)
        {
            return Array.IndexOf(this.genericList, element);
        }

        private void AutoDoubleSize()
        {
            T[] newList = new T[this.genericList.Length * 2];
            Array.Copy(this.genericList, newList, this.genericList.Length);
            this.genericList = newList;
        }

        private void CheckIfPositionIsCorrect(int position)
        {
            if (position < 0 || position >= genericList.Length)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }
        }

        public void Clear()
        {
            this.index = 0; // reseting the index to zero wont delete the array but they wont be accessable
        }

        public T Max()
        {
            T max = genericList[0];

            for (int i = 1; i < this.genericList.Length; i++)
            {
                if (max.CompareTo(genericList[i]) < 0)
                {
                    max = genericList[i];
                }
            }
            return max;
        }

        public T Min()
        {
            T min = genericList[0];

            for (int i = 1; i < this.genericList.Length; i++)
            {
                if (min.CompareTo(genericList[i]) > 0)
                {
                    min = genericList[i];
                }
            }
            return min;
        }

        public override string ToString()
        {
            if (index == 0)
            {
                return "The generic list is empty!";
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.genericList.Length; i++)
            {
                sb.AppendFormat("Item #{0} is {1}\r\n", i, this.genericList[i]);
            }
            return sb.ToString();
        }
    }
}
