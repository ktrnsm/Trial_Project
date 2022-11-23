using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string ShippedAddress { get; set; }
        public decimal TotalPrice {get;set;}

        //One of the properties we open in order to capture the information in the order transactions more easily is TotalPrice... You just have to be very careful here. If there is a situation that will really speed you up, you should add this information here... At the same time, this is the case. should not be exaggerated... In other words, all the data of the relevant structure should never be put in this class completely... Only specific parts should be taken...
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? AppUserID { get; set; }
        public int? ShipperID { get; set; }
        
        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }


    }
}
