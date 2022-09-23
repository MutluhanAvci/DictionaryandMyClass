using System;
using System.Collections.Generic;

namespace DictionaryandMyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(0, "Mutluhan");
            kullanicilar.Add(1, "Yılmaz");
            kullanicilar.Add(2, "Avcı");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine($"{item.Key}  sözlük değeri:  {item.Value}");
            }
            MyClass<int>myClass = new MyClass<int>();
            myClass.MyAdd(23);
            myClass.MyAdd(35);
            Console.WriteLine(myClass.MyCount);
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.AddTo(0, "Sebastian Vettel");
            myDictionary.AddTo(1, "Bariyerlerdeeeee");
            myDictionary.ShowAll();
      
        }
    }
}
