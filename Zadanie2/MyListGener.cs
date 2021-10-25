using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class MyList<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
    {                  // изменяю  поля не в другом классе - обошелся без 'static' .
        int n = 0;     // изменяю все поля не в конструкторе.
        T[] array = new T[0];
        T[] mirror;// = new T[0];  // n - static;
        int position = -1;

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
        public void Add(T argument)
        {
            n++;           
            array = new T[n]; // T[] armass = new T[n];  // получим 'лишний' массив. можно использ array;//создаю array только здесь.
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    array[i] = argument;
                else
                    array[i] = mirror[i];
            }
            //  MyList<T> mycollect = new MyList<T>(array);  // не нужно каждый раз создавать новый экземпляр всего класса, а только массива.
            mirror = new T[n];                // экземпляр mirror аж здесь.
            for (int i = 0; i < n; i++)
                mirror[i] = array[i];
        }
        public void Del(int argument)
        {
            n--;
            array = new T[n];
            for(int i=0; i< n; i++)
            {
                if (i >= argument)
                    array[i] = mirror[i + 1];
                else
                    array[i] = mirror[i];
            }
            mirror = new T[n];
            for (int i = 0; i < n; i++)
                mirror[i] = array[i];
        }

        public T this[int index]
        {
            get { return array[index]; }
        }
        public int LengthN         // общее колич элементов;
        {
            get { return n; }
        }
    }
}
