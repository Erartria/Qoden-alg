using System;

namespace task1
{
    public class HashTable
    {
        public Array<ListNode> values;
        public readonly int n;

        public HashTable(int n)
        {
            this.n = n;
            this.values = new Array<ListNode>(n);
        }

        public void Insert(int newValue)
        {
            int hash = GenerateHash(newValue);
            if (values.objects[hash] == null)
            {
                values.objects[hash] = new ListNode(newValue);
                return;
            }
            values.objects[hash].Insert(newValue);
        }

        private int GenerateHash(int x)
        {
            return x % n;
        }

        public override string ToString()
        {
            String result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result = String.Concat(result, $"{i}: {values.objects[i]}\n");
            }

            return result;
        }
    }
}