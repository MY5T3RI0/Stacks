using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    class LinkedStack<T>
    {
        public Item<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            GetHead(data);
        }

        private void GetHead(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Count++;
        }

        public void Push(T data)
        {
            if (Count == 0)
            {
                GetHead(data);
            }
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;

        }

        public T Pop()
        {
            var item = Head;
            Head = Head.Previous;
            Count--;
            return item.Data;
        }

        public T Peek()
        {
            var item = Head;
            Count--;
            return item.Data;
        }

        public override string ToString()
        {
            return $"Связный стек с {Count} элементами";
        }
    }
}
