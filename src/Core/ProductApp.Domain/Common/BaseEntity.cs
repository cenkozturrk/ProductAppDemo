using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
    }
}
