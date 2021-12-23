using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public String Message { get; set; }
    }
}
