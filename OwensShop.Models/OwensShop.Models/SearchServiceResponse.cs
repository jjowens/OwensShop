using System;
using System.Collections.Generic;
using System.Text;

namespace OwensShop.Models
{
    public class SearchServiceResponse<T>
    {
        public T Data { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public string LogMessage { get; set; }
        public bool Success { get; set; }
    }
}
