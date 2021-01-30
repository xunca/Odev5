
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> schoolNumber = new MyDictionary<int, string>();
            schoolNumber.Add(112, "7-A");
            schoolNumber.Add(134, "7-C");
            schoolNumber.Add(211, "6-B");

            int j = 0;

            for (int i = 0; i < schoolNumber.Length; i++)
            {
                Console.WriteLine(j + ". Kayıtlı öğrenci numarası : " + schoolNumber.value[i] + " Sınıfı : " + schoolNumber.key[i]);
                j = j + 1;
            }

        }
    }
}
