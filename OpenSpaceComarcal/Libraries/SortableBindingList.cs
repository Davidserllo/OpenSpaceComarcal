using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Libraries
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList() : base() { }

        public SortableBindingList(IEnumerable<T> list) : base(new List<T>(list)) { }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            List<T> items = this.Items.ToList();

            if (direction == ListSortDirection.Ascending)
            {
                items = items.OrderBy(x => prop.GetValue(x)).ToList();
            }
            else
            {
                items = items.OrderByDescending(x => prop.GetValue(x)).ToList();
            }

            this.ClearItems();

            foreach (T item in items)
            {
                this.Add(item);
            }

            _sortProperty = prop;
            _sortDirection = direction;
            _isSorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override bool SupportsSortingCore => true;

        protected override bool IsSortedCore => _isSorted;

        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override ListSortDirection SortDirectionCore => _sortDirection;

        public void RemoveSort()
        {
            _sortProperty = null;
            _sortDirection = ListSortDirection.Ascending;
            _isSorted = false;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }
}
