using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDashTable
{
    public abstract class Span
    {
        public int Index { get; set; }
        public int Value { get; set; }
    }

    public class Rowspan : Span { }

    public class Colspan : Span { }


    public class Cell
    {
        public string Text { get; set; }
        public Rowspan Rowspan { get; set; }
        public Colspan Colspan { get; set; }
    }

    public class SpanCell
    {
        public string Text { get; set; }
        public Tuple<int, int> Position { get; set; }
        public int ColspanIndex { get; set; }
        public int RowspanIndex { get; set; }
    }

    public class NegativeIndexList<T>
    {
        private List<T> _list = new List<T>();

        public T this[int i]
        {
            get
            {
                return _list[i + 1];
            }
            set
            {
                int adjustedIndex = i + 1;
                _list.Insert(adjustedIndex, value);
                //_list[i + 1] = value;
            }
        }

        public void Add(T element)
        {
            _list.Add(element);
        }

    }
}
