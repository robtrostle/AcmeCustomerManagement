using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();//Established a collaborative relationship between the customer/address repositories
        }

        public Customer Retrieve(int customerId)
        {
            //Creat the instance of the customer class
            //Pass in the requested id
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer
            //Temporary hardcoded values

            if (customerId == 1)

            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
                //Now when any code requests to retrieve a customer, this method will retrieve and populate the customer and its assoc. addresses. 
            }
            return customer;
            }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //Call and update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
