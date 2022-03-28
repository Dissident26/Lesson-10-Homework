using System.Collections;

namespace MyLib
{
    public class MyList : IList<MyItem>
    {
        private readonly List<MyItem> Items = new();
        public MyItem this[int index] { get => Items[index]; set => Items[index] = value; }

        public int Count => Items.Count;

        public bool IsReadOnly => false;

        public void Add(MyItem item)
        {
            Items.Add(item);
        }

        public void Clear()
        {
            Items.Clear();
        }

        public bool Contains(MyItem item)
        {
            return Items.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return Items.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            Items.Insert(index, item);  
        }

        public bool Remove(MyItem item)
        {
            return Items.Remove(item); 
        }

        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyItem
    {
        public int Id;
        public string Name;

        public MyItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
            public override string ToString()
        {
            return $"MyItem: id = {Id}, name = {Name}";
        }
    }
}