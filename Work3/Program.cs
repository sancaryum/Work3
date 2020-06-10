using System;
using System.Collections;
using System.Collections.Generic;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *STATİK DİZİ
             *
             */

            int[] sayilar = new int[5];//5boyutlu bir statik dizi tanımladık
            
            Random r = new Random();
            //for içinde diziye rastgele değerler atadık
            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1,7);

            Array.Sort(sayilar);//diziyi sıralar 
            /*
            //atadığımız bu değerleri yazdıralım
            for (int i = 0; i < sayilar.Length; i++)
                Console.WriteLine(sayilar[i]);
            */
            
            //elimizdeki diziyi yazdırmanın bir başka şekli
            /*
             foreach(int sayiNameAtandi in sayilar )
                Console.WriteLine(sayiNameAtandi);
            */
            //dizinin içindeki elemanın hangi indiste olduğunu bulma
            int index = Array.IndexOf(sayilar, 5);//5 sayisi sayilar dizisi içerisinde hangi indexte.5 yoksa -1 döner
            Console.WriteLine("5 sayisi {0} .indexte ", index);

            int index2 = Array.BinarySearch(sayilar, 5);//indexof ile aşağı yukarı aynı. Dizinin içinde eleman aramaya yarar.
            Console.WriteLine("5 sayisi " + index2 + ".indexte");

            /*
             * DİNAMİK DİZİ
             * 
             * */

            ArrayList rehber = new ArrayList();

            rehber.Insert(0, "mehmet");//insert ile belirli indise ekleme yapılabilir
            rehber.InsertRange(1, sayilar);//InsertRange ile belirtilen indisten itibaren dizinin içine başka dizi ekleyebiliriz.

            rehber.Add("hasan");
            Console.WriteLine(rehber.Count + "\n ");//dizinin eleman sayisini verir
            /*
            rehber.Remove("hasan");//hasanı kaldırır
            rehber.RemoveAt(0);//1.indexteki elemanı siler
            rehber.RemoveRange(1, 5);//1 nolu indexten başlayarak 5 tane elemanı siler
            */
            /*
            bool varMı = rehber.Contains("mehmet");//var mı
            int index3 = rehber.IndexOf("hasan");
            Console.WriteLine("indexi: " + index3 + " var mi: " + varMı);

            for (int i = 0; i < rehber.Count; i++)
                Console.WriteLine(rehber[i]);

            rehber.Reverse();

            for (int i = 0; i < rehber.Count; i++)
                Console.WriteLine(rehber[i]);

            */

            /*
             * LİST İLE KULLANIM
             * */

            List<String> friends =  new List<String>();
            List<String> dostlar = new List<String>();
            friends.Add("kaan");
            friends.Insert(1, "burak");
            friends.Insert(2, "tarık");
            //friends.Insert(3, "mehmet");

           Console.WriteLine("count (eleman sayisi)" + friends.Count + "capacity(kac bit)" + friends.Capacity);


            foreach (String arkadaslar in friends)
                Console.WriteLine(arkadaslar);

            //friends.RemoveRange(3,1); //3 ten başlayarak 1 eleman kaldırır

            Console.WriteLine("count (eleman sayisi)" + friends.Count + "capacity(kac bit)" + friends.Capacity);

            Console.ReadLine();
        }
    }
}
