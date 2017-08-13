using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class Database
    {
        private IDictionary<int, string> collection;

        public Database()
        {
            this.Collection = new Dictionary<int, string>();
        }

        private IDictionary<int, string> Collection
        {
            set
            {
                if (value.Count > 16)
                {
                    throw new InvalidOperationException();
                }
                this.collection = value;
            }
        }

        public void Add(int id, string name)
        {
            if (this.collection.Any(p => p.Key == id || p.Value == name))
            {
                throw new InvalidOperationException();
            }
            this.collection.Add(id, name);
        }

        public void Remove()
        {
            if (!this.collection.Any())
            {
                throw new InvalidOperationException();
            }
            int removeId = this.collection.LastOrDefault().Key;
            this.collection.Remove(removeId);
        }

        public KeyValuePair<int, string> FindByUsername(string username)
        {
            if (this.collection.Values.All(p => p != username))
            {
                throw new InvalidOperationException();
            }

            KeyValuePair<int, string> target = this.collection.FirstOrDefault(p => p.Value == username);

            if (target.Value == null)
            {
                throw new ArgumentNullException();
            }

            return target;
        }

        public KeyValuePair<int, string> FindById(int id)
        {
            if (!this.collection.ContainsKey(id))
            {
                throw new InvalidOperationException();
            }

            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return this.collection.FirstOrDefault(p => p.Key == id);
        }
    }
}