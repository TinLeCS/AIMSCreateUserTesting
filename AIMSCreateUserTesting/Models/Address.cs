using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMSCreateUserTesting.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public string City { get; set; }
        public virtual Entity Entity { get; set; }
    }
}