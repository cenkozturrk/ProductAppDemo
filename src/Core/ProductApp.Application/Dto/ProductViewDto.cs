using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Dto
{
    //Dış dünya ile bağlantı kurabilmek için oluşturduk.
    public class ProductViewDto
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
    }
}
