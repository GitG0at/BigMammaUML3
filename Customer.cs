using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Customer : ICustomer
    {
        public int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Adress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
