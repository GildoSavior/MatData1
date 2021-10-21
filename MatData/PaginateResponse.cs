using System.Collections.Generic;
using System.Linq;

namespace MatData
{
    public class PaginateResponse<T>
    {
        public int Total { get; set; }

        public IEnumerable<T> Data { get; set; }

        public PaginateResponse(IEnumerable<T> data, int i, int len)
        {
            Data = data.Skip((i - 1) * len).Take(len).ToList();
            Total = data.Count();
        }
    }
}
