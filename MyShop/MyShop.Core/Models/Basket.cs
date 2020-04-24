using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Basket : BaseEntity
    {
        public virtual ICollection<BasketItem> BasketItem { get; set; }

        public Basket()
        {
            this.BasketItem = new List<BasketItem>(); 
        }
    }
}
