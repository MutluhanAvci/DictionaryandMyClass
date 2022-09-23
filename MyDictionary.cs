using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryandMyClass
{
    public class MyDictionary<T1,T2>
    {
        T1[] keyArray;
        T2[] valueArray;
        T1[] tempkey;
        T2[] tempvalue;
        
        public MyDictionary()
        {
            keyArray = new T1[0];
            valueArray = new T2[0];
            
        }

        public void AddTo(T1 keyitem, T2 valueitem)
        {
            tempkey = keyArray;
            keyArray = new T1[keyArray.Length + 1];
            keyArray[keyArray.Length - 1] = keyitem;
            tempvalue = valueArray;
            valueArray = new T2[valueArray.Length + 1];
            valueArray[valueArray.Length - 1] = valueitem;
            for (int i = 0; i < tempkey.Length; i++)
            {
                keyArray[i] = tempkey[i];
                valueArray[i] = tempvalue[i];
            } 
        }
        public void ShowAll()
        {
          

            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine($"{keyArray[i]} {valueArray[i]} ");
                
            }
        }


        public int Count
        {
            get { return keyArray.Length ; }
            
        }
        

        //public int Show
        //{
        //    get
        //    {
        //        string showKey, showValue, showResult;

        //        for (int i = 0; i < keyArray.Length; i++)
        //        {
        //            showKey = keyArray[i].ToString();
        //            showValue = valueArray[i].ToString();
        //            showResult = showKey + " " + showValue;
        //            return showResult;
        //        }
                
        //    }
            
        //}
        
        





    }
    
}

