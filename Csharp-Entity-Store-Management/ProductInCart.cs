using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Entity_Store_Management
{
    class ProductInCart
    {
        public int productID { get; set; }
        public string name { get; set; }
        public long price { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
        public long totalAmount { get; set; }

        public void setDiscount(int discount)
        {
            long amount = this.price * this.quantity;
            this.totalAmount = amount - amount * discount / 100;
        }

        public ProductInCart()
        {

        }

        public ProductInCart(int productID, string name, long price, int quantity)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.totalAmount = price * quantity;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            ProductInCart product = (ProductInCart)obj;
            return this.name.Equals(product.name);
        }

        public bool CompareID(ProductInCart product)
        {
            return this.productID.Equals(product.productID);
        }
    }
}
