using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInto
{
     class Mylist <T> // list isimli liste oluşturuldu (1)
    {
        T[] items;   //(2) t isimli liste oluşturuldu
        // constructor (yapıcı method)
        public Mylist()   //(3) ctor yazılarak yapıcı method oluşturuldu  ve items listedesimin boyutu verildi
        {
            // array dizlerinin new lenme zorunluluğu vardır    
            items= new T[0];
        }

        
        public void add (T item) // add isimli bir fonksiyon eklendi 
        {
            T[] tempArray = items; // geçici dizi referansı tutar  eski değerleri kaybetmemek için oluşturduk
            items = new T[items.Length+1]; 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item; // istenilen eleman şu an eklendi  
        }
    }
}
