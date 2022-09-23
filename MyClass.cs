using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryandMyClass
{
    class MyClass<T>
    {
        T[] items;
        T[] _tempitems;
        public MyClass()
        {
            items = new T[0];
        }
        public void MyAdd(T item)
        {
            _tempitems = items;
            items = new T[items.Length + 1];
            
            for (int i = 0; i < _tempitems.Length; i++)
            {
                items[i] = _tempitems[i];
            }
            items[items.Length - 1] = item;
        }
        public int MyCount 
        { 
            get { return items.Length; }//propfull
        }

    }
}
