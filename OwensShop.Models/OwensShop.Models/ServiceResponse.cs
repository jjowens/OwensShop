using System;
using System.Collections.Generic;
using System.Text;

namespace OwensShop.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public string LogMessage { get; set; }
        public bool Success { get; set; }

    }
}
