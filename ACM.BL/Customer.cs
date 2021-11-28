using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable  ///inherits from the Entity Base class
    {
        public Customer(): this(0)
        {
            //default constructor has no code. If there is no need, don't create one. 
        }
        public Customer(int customerID)
        {
            //helpful for unit tests. We have overloaded the constructor
            CustomerId = customerID;
            AddressList = new List<Address>(); //We need this so that the list isn't defaulted to a null 
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }//auto implemented properties

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; } //belongs to the class itself, rather than any specific instance. 
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;  //can be read only if only a getter
            }
            set
            {
                _lastName = value;//can be write only and also do data validation
            }
        }
        //Interpolated string allow us to use placeholders for our values instead of string concatenation
        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;  //Returns fullname so we can see while debugging
        //{
        //    return base.ToString();
        //}

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
