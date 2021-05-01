using System.Collections.Generic;
using System.Linq;

namespace DataPaging
{
    public static class DataPaging
    {
        public static List<T> Pagination<T>(this IList<T> genericList, int page, int quantity)
        {
            return genericList.Skip((page - 1) * quantity)
                    .Take(quantity)
                    .ToList();
        }
    }
}
