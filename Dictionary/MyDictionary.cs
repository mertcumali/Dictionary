using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        TKey[] tempKeys;
        TValue[] tempValues;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
        
            tempKeys = keys;
            tempValues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;

            for (int i = 0; i < tempKeys.Length; i++)
            {
                if (key.Equals(tempKeys[i]))
                {
                    throw new ArgumentException("An item with the same key has already been added.");
                }
            }
        }

        public int Count
        {
            get { return keys.Length; }

        }

    }
}
