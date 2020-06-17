using System.Collections.Generic;

namespace Dictionary
{
    class CustomDictionary<K, V>
    {
        private List<CustomKeyValuePair<K, V>> list = null;

        public CustomDictionary()
        {
            this.list = new List<CustomKeyValuePair<K, V>>();
        }

        public void Add(K key, V value)
        {
            var pair = new CustomKeyValuePair<K, V>(key, value);
            this.list.Add(pair);
        }
    }
}
