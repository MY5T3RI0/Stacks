using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    /// <summary>
    /// Простой стек.
    /// </summary>
    /// <typeparam name="T">Тип элементов.</typeparam>
    class SimpleStack<T>
    {
        /// <summary>
        /// Список элементов.
        /// </summary>
        private List<T> Items = new List<T>();

        /// <summary>
        /// Размер стека.
        /// </summary>
        public int Count => Items.Count;

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

            Items.Add(data);
        }

        /// <summary>
        /// Получить верхний элемент.
        /// </summary>
        /// <returns>Верхний элемент.</returns>
        public T Pop()
        {
            var item = Items.LastOrDefault();
            Items.RemoveAt(Count - 1);
            return item;
        }

        /// <summary>
        /// Посмотреть верхний элемент.
        /// </summary>
        /// <returns>Верхний элемент.</returns>
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
