using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] numbers;
        V[] names;
        public MyDictionary()
        {
            numbers = new K[0];
            names = new V[0];
        }
        public void Add(K number, V name)
        {
            K[] tempArray1= numbers;
            numbers = new K[numbers.Length + 1];
            
            for (int i = 0; i < tempArray1.Length; i++)
            {
                numbers[i] = tempArray1[i];
            }

            numbers[numbers.Length - 1] = number;

            V[] tempArray2 = names;
            names = new V[names.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                names[i] = tempArray2[i];
            }

            names[names.Length - 1] = name;
        }

        public int Length1
        {
            get { return numbers.Length; }
        }
        public K[] Numbers
        {
            get { return numbers; }
        }

        public int Length2
        {
            get { return names.Length; }
        }
        public V[] Names
        {
            get { return names; }
        }
    }
}
