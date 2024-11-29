using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stec.Examples
{
    public class PriorityQueueImpl
    {
        private int maxSize;
        private long[] queArray;
        private int nItems;

        public PriorityQueueImpl(int s)
        {
            maxSize = s;
            queArray = new long[maxSize];
            nItems = 0;
        }

        public void Insert(long item)
        {
            if (IsFull())
                throw new InvalidOperationException("Ошибка: Приоритетная очередь переполнена.");
            int j;
            for (j = nItems - 1; j >= 0; j--)
            {
                if (item > queArray[j])
                    queArray[j + 1] = queArray[j];
                else
                    break;
            }
            queArray[j + 1] = item;
            nItems++;
        }

        public long Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Ошибка: Приоритетная очередь пуста.");
            return queArray[--nItems];
        }

        public long PeekMin()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Ошибка: Приоритетная очередь пуста.");
            return queArray[nItems - 1];
        }

        public bool IsEmpty() => (nItems == 0);
        public bool IsFull() => (nItems == maxSize);
    }
}
