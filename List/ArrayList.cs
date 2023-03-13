using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists;

namespace Lists
{
    public class ArrayList : List
    {
        private object[] data;
        private int cap;
        private int SIZE;
        public ArrayList(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }

        public void add(object e)
        {
            add(SIZE, e);
        }

        public void add(int index, object e)
        {
            ensureCapacity();
            for (int i = SIZE; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = e;
            SIZE++;
        }

        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }

        public object get(int index)
        {
            return data[index];
        }

        public int indexOf(object e)
        {
            for (int i = 0; i < SIZE; i++)
                if (e.Equals(data[i]))
                    return i;
            return -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(int index)
        {
            if (index >= SIZE) return;
            for (int i = index + 1; i < SIZE; i++)
                data[i - 1] = data[i];
            data[--SIZE] = null;
        }

        public void remove(object e)
        {
            int i = indexOf(e);
            if (i > -1)
                remove(i);
        }

        public void set(int index, object e)
        {
            data[index] = e;
        }

        public int size()
        {
            return SIZE;
        }
        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
                data = tempdata;
            }
        }
    }
}
