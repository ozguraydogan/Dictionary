using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary <TKey, TValue>
    {
        TKey[] keyItems;
        TValue[] valueItems;

        public MyDictionary()
        {
            keyItems = new TKey[0];
            valueItems = new TValue[0];
        }

        public void Add(TKey keys,TValue values)
        {
            TKey[] tempKeys = keyItems;
            TValue[] tempValues = valueItems;

            keyItems = new TKey[keyItems.Length + 1];
            valueItems = new TValue[valueItems.Length + 1];

            for(int i=0;i<tempKeys.Length;i++)
            {
                keyItems[i] = tempKeys[i];
            }

            for(int j=0;j<tempKeys.Length;j++)
            {
                valueItems[j] = tempValues[j];
            }

            keyItems[keyItems.Length - 1] = keys;
            valueItems[valueItems.Length - 1] = values;

        }

        public void ShowItems()
        {
            for(int i=0;i<keyItems.Length;i++)
            {
                Console.WriteLine(keyItems[i] + " , " + valueItems[i]);
            }
        }
    }
}
