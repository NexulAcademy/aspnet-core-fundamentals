using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrm
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();
    }
}
