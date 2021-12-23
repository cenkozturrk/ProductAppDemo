using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public T Value { get; set; }

        //kendi value mizi direk dısardan gelen value olarak set edebiliriz.
        public ServiceResponse(T value)
        {
            Value = value;
        }

        public ServiceResponse()
        {

        }
    }
}
