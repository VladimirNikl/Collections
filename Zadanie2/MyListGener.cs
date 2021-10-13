using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class MyList<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
    {
        private T[] array;
        private int position = -1;

        public MyList(params T[] mass)
        {
           this.array = mass;   // T[] array = mass;  не T[]
        }           

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }
        T IEnumerator<T>.Current
        {
            get { return this.array[position]; }
        }
        object IEnumerator.Current
        {
            get { return array[position]; }
        }
        bool IEnumerator.MoveNext()
        {
            position++;
            if (position >= 0 && position < array.Length)
                return true;
            else
            { 
                position = -1;
                return false;
            }
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        void IDisposable.Dispose() { }
    }
}
