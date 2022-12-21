using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samples
{
    internal class MyDictionary<T>
    {
        T[] _array;
        T[] _Temparray;
        
        public MyDictionary()
        {
            _array= new T[0]; // listemin boyutunu belirttim
        }
        public void Add(T item)
        {
            T[] _Temparray = _array;
            _array = new T[_array.Length+1];

            for (int i = 0; i < _Temparray.Length; i++)
            {
                _array[i] = _Temparray[i];
            }
            _array[_array.Length-1] = item;

        }

        public int count { get { return _array.Length; } }
        public T[] isim 

        {
            get { return _array; }
        }


    }
}
