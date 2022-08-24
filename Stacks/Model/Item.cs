using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Model
{
    /// <summary>
    /// Элемент.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Item<T>
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Ссылка на предыдущий элемент.
        /// </summary>
        public Item<T> Previous { get; set; }

        /// <summary>
        /// Создать новый элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public Item(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
