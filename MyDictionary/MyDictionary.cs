using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary

{
    class MyDictionary<TKeys, TValues>
    {
        private TKeys[] keysArray;
        private TValues[] valuesArray;
        public MyDictionary()
        {
            keysArray = new TKeys[0];
            valuesArray = new TValues[0];
        }

       
        public void Add(TKeys key, TValues value)
        {
            TKeys[] tempKeys;
            TValues[] tempValues;

            tempKeys = keysArray;
            tempValues = valuesArray;

            keysArray = new TKeys[keysArray.Length + 1];
            valuesArray = new TValues[valuesArray.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keysArray[i] = tempKeys[i];
                valuesArray[i] = tempValues[i];
            }

            keysArray[keysArray.Length - 1] = key;
            valuesArray[valuesArray.Length - 1] = value;

        }
        public void List()
        {
            for (int i = 0; i < keysArray.Length; i++)
            {
                Console.WriteLine(keysArray[i] + " : " + valuesArray[i]);
            }
        }
      
    }
}
