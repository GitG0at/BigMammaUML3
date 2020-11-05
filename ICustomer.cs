using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public interface ICustomer
    {
        int Id { get; }
        string Name { get; set; }
        string Adress { get; set; }
        string PhoneNo { get; set; }

        string DogName { get; set; }
    }

}
