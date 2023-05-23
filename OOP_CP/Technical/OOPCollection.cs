using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP
{
    public class OOPCollection<T> : IEnumerable
    {
        private List<T> _dataCollection;

        //public int Count { get { return _dataCollection.Count; } }

        public OOPCollection()
        {
            _dataCollection = new List<T>();
        }

        public void Add(T item)
        {
            _dataCollection.Add(item);
        }

        public void Remove(T name)
        {
            _dataCollection.Remove(name);
        }

        public void Clear()
        {
            _dataCollection.Clear();
        }

        public List<T> GetList()
        {
            return _dataCollection;
        }

        public void SetList(List<T> collection)
        {
            _dataCollection = collection;
        }

        public IEnumerator GetEnumerator()
        {
            return _dataCollection.GetEnumerator();
        }
    }
}
