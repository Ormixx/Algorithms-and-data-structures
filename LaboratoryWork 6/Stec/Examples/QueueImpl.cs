using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stec.Examples
{
    public class QueueImpl
    {
        private int maxSize;
        private long[] queArray;
        private int front;
        private int rear;
        private int nItems;

        public QueueImpl(int s)
        {
            maxSize = s;
            queArray = new long[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
                throw new InvalidOperationException("Ошибка: Очередь переполнена.");
            if (rear == maxSize - 1)
                rear = -1;
            queArray[++rear] = j;
            nItems++;
        }

        public long Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Ошибка: Очередь пуста.");
            long temp = queArray[front++];
            if (front == maxSize)
                front = 0;
            nItems--;
            return temp;
        }

        public long PeekFront()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Ошибка: Очередь пуста.");
            return queArray[front];
        }

        public bool IsEmpty() => (nItems == 0);
        public bool IsFull() => (nItems == maxSize);
    }

}
