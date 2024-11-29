using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stec.Examples
{
    public class StackImpl
    {
        private int maxSize;
        private char[] stackArray;
        private int top;

        public StackImpl(int s)
        {
            maxSize = s;
            stackArray = new char[maxSize];
            top = -1;
        }

        public void Push(char j)
        {
            if (IsFull())
                throw new InvalidOperationException("Ошибка: Стек переполнен.");
            stackArray[++top] = j;
        }

        public char Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Ошибка: Стек пуст.");
            return stackArray[top--];
        }

        public char Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Ошибка: Стек пуст.");
            return stackArray[top];
        }

        public bool IsEmpty() => (top == -1);
        public bool IsFull() => (top == maxSize - 1);
    }

}
