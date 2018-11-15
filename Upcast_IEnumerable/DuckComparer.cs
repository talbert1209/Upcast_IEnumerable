using System.Collections.Generic;

namespace Upcast_IEnumerable
{
    public partial class DuckComparer : IComparer<Duck>
    {
        public DuckComparer.SortCriteria SortBy = DuckComparer.SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == DuckComparer.SortCriteria.SizeThenKind)
            {
                if (x.Size < y.Size)
                    return -1;
                if (x.Size > y.Size)
                    return 1;
                if (x.Kind < y.Kind)
                    return -1;
                if (x.Kind > y.Kind)
                    return 1;
                return 0;
            }
            else
            {
                if (x.Kind < y.Kind)
                    return -1;
                if (x.Kind > y.Kind)
                    return 1;
                if (x.Size < y.Size)
                    return -1;
                if (x.Size > y.Size)
                    return 1;
                return 0;
            }
        }
    }
}