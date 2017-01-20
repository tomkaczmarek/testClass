using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class GenericClass<T> : IEnumerable<T>
    {
        private IList<T> list = new List<T>();

        public T this[int index]
        {
            get { return list[index]; }
            set { list.Insert(index, value); }
        }

        public void Add(T o)
        {
            list.Add(o);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
