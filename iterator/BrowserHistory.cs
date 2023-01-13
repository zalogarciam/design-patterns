public class BrowserHistory<T>
{
    private List<T> Urls = new List<T>();

    public void Push(T url)
    {
        Urls.Add(url);
    }

    public void Pop()
    {
        Urls.RemoveAt(Urls.Count - 1);
    }

    public IIterator<T> CreateIterator() {
        return new ListIterator(this);
    }

    public class ListIterator : IIterator<T>
    {
        private BrowserHistory<T> History;
        private int Index;
        public ListIterator(BrowserHistory<T> history)
        {
            this.History = history;
        }
        public T Current()
        {
            return History.Urls[Index];
        }

        public bool HasNext()
        {
            return (Index < History.Urls.Count);
        }

        public void Next()
        {
            Index++;
        }
    }
}
