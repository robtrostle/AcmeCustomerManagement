using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product : EntityBase, ILoggable  ///inherits from the Entity Base class
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            ProductID = productID;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();//no need to pass in parameter since it's an extension method. 
            }
            set
            {
                _productName = value;
            }
        }
        public string Log() =>
            $"{ProductID}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName; //A lambda to shorten the code (means we are returning Product name
        //{
        //    return ProductName;
        //}
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
