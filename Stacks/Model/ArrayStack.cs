using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    class ArrayStack<T>
    {
        private T[] Items;
        private int Current = 0;
        private readonly int Size = 10;

        public ArrayStack(int size = 10)
        {
            Items = new T[size];
            Size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            Items = new T[size];
            Size = size;
            Items[Current] = data;
            Current++;
        }

        public void Push(T data)
        {
            if (Current < Size)
            {
                Items[Current] = data;
                Current++;
            }
            else 
            {
                throw new StackOverflowException("Переполнение стека");
            }
        }

        public T Pop()
        {
            if (Current > 0)
            {
                Current--;
                var item = Items[Current];
                return item;
            }
            else 
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (Current > 0)
            {
                var item = Items[Current - 1];
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public override string ToString()
        {
            return $"Переполняемый стек с {Current} элементов";
        }
    }
}
