using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMSCreateUserTesting.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public string ContactDetail { get; set; }
        public virtual Entity Entity { get; set; }

    }
}