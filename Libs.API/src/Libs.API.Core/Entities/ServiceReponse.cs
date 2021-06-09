using System;
using System.Collections.Generic;
using System.Text;

namespace Libs.API.Core.Entities
{
    public class ServiceReponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
    }
}
