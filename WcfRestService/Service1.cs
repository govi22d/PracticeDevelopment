using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Product> GetProducts()
        {
            List<Product> lst = new List<Product> {
              new Product { ProductId = 1,
              ProductName = "T-Shirt",
              ProductDescription = "Medium size"                 },
              new Product { ProductId = 2, ProductName = "Hero Honda",
              ProductDescription = "Very good vehicle" },
              new Product { ProductId = 3, ProductName = "Mobile",
              ProductDescription = "about mobile"                   }
          };
            return lst;
        }
    }
}
