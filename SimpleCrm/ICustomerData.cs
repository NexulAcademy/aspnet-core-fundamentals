using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrm
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        void Save(Customer customer);
    }
}
