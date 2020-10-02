using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kr517216MIS4200demo1.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public string description { get; set; }
        public DateTime OrderDate { get; set; }
        public int customerID { get; set; }
        public Customer customer { get; set; }

    }
}