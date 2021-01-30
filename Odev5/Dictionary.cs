using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] schoolNumber;
        V[] schoolClasses;

        public MyDictionary()
        {
            schoolNumber = new K[0];
            schoolClasses = new V[0];
        }

        public void Add(K number, V classes)
        {
            K[] tempSchoolNumber = schoolNumber;
            schoolNumber = new K[schoolNumber.Length + 1];
            schoolClasses = new V[schoolClasses.Length + 1];

            for (int i = 0; i < tempSchoolNumber.Length; i++)
            {
                schoolNumber[i] = tempSchoolNumber[i];
            }
            for (int i = 0; i < schoolClasses.Length; i++)
            {
                V[] tempSchoolClasses = classes;
                schoolClasses[i] = tempSchoolClasses[i];
            }

            schoolNumber[schoolNumber.Length - 1] = number;
            schoolClasses[schoolClasses.Length - 1] = classes;

        }

        public K[] key
        {
            get { return schoolNumber; }
        }
        public V[] value
        {
            get { return schoolClasses; }
        }

        public int Length
        {
            get { return schoolNumber.Length; }
        }

    }
}