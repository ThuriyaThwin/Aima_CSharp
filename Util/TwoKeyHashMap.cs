namespace AIMA.Core.Util
{
    using System;
    using System.Collections.Generic;
    using AIMA.Core.Util.DataStructure;

    /**
     * Provides a hash map which is indexed by two keys. In fact this is
     * just a hash map which is indexed by a pair containing the two
     * keys. The provided two-key access methods try to increase code
     * readability.
     * @author Ruediger Lunde
     *
     * @param <K1> First key
     * @param <K2> Second key
     * @param <V> Result value
     */

    public class TwoKeyHashMap<K1, K2, V> : HashMap<Pair<K1, K2>, V>
    {
        private const long serialVersionUID = -2232849394229644162L;

        public void put(K1 key1, K2 key2, V value)
        {
            super.put(new Pair<K1, K2>(key1, key2), value);
        }

        public V get(K1 key1, K2 key2)
        {
            return super.get(new Pair<K1, K2>(key1, key2));
        }

        public bool containsKey(K1 key1, K2 key2)
        {
            return super.containsKey(new Pair<K1, K2>(key1, key2));
        }

        public V remove(K1 key1, K2 key2)
        {
            return super.remove(new Pair<K1, K2>(key1, key2));
        }

        //	public static void main(String[] args) {
        //		TwoKeyHashMap<String, String, String> hash = new TwoKeyHashMap<String, String, String>();
        //		hash.put("A", "A", "C");
        //		hash.put("A", "A", "D");
        //		hash.put("B", "A", "E");
        //		System.Console.WriteLine(hash.get("A", "A"));
        //		System.Console.WriteLine(hash.get("A", "B"));
        //	}
    }
}