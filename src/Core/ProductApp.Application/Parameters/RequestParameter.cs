using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Parameters
{
    public class RequestParameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public RequestParameter(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }


}
