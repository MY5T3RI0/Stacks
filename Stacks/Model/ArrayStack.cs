using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    /// <summary>
    /// Стек на массиве.
    /// </summary>
    /// <typeparam name="T">Данные элементов.</typeparam>
    class ArrayStack<T>
    {
        /// <summary>
        /// Массив элементов.
        /// </summary>
        private T[] Items;

        /// <summary>
        /// Размер.
        /// </summary>
        private int Current = 0;

        /// <summary>
        /// Максимальный размер.
        /// </summary>
        private readonly int Size = 10;

        /// <summary>
        /// Создать пустой стек.
        /// </summary>
        /// <param name="size">Максимальный размер.</param>
        public ArrayStack(int size = 10)
        {
            Items = new T[size];
            Size = size;
        }

        /// <summary>
        /// Создать новый стек.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        /// <param name="size">Максимальный размер.</param>
        public ArrayStack(T data, int size = 10) : this(size)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            if (size == 0)
            {
                throw new ArgumentNullException(nameof(data), "Размер не может 0");
            }

            Items = new T[size];
            Size = size;
            Items[Current] = data;
            Current++;
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

        /// <summary>
        /// Получить головной элемент.
        /// </summary>
        /// <returns>Головной элемент.</returns>
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

        /// <summary>
        /// Посмотреть головной элемент.
        /// </summary>
        /// <returns></returns>
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
