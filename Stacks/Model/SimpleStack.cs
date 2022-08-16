using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    class SimpleStack<T>
    {
        private List<T> Items = new List<T>();

        public int Count => Items.Count;

        public void Push(T data)
        {
            Items.Add(data);
        }

        public T Pop()
        {
            var item = Items.LastOrDefault();
            Items.RemoveAt(Count - 1);
            return item;
        }

        public T Peek()
        {
            var item = Items.LastOrDefault();
            return item;
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами";
        }
    }
}
