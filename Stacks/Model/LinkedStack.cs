using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    /// <summary>
    /// Связный стек.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedStack<T>
    {
        /// <summary>
        /// Головной элемент.
        /// </summary>
        public Item<T> Head { get; set; }

        /// <summary>
        /// Размер стека.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Создать пустой стек.
        /// </summary>
        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        /// <summary>
        /// Создать новый стек.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public LinkedStack(T data)
        {
            GetHead(data);
        }

        /// <summary>
        /// Добавить головной элемент.
        /// </summary>
        /// <param name="data"> Данные нового элемента.</param>
        private void GetHead(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            var item = new Item<T>(data);
            Head = item;
            Count++;
        }

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public void Push(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            if (Count == 0)
            {
                GetHead(data);
            }
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;

        }

        /// <summary>
        /// Получить головной элемент.
        /// </summary>
        /// <returns>Головной элемент.</returns>
        public T Pop()
        {
            var item = Head;
            Head = Head.Previous;
            Count--;
            return item.Data;
        }

        /// <summary>
        /// Посмотреть головной элемент.
        /// </summary>
        /// <returns></returns>
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
