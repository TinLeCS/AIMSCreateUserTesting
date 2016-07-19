using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AIMSCreateUserTesting.Models
{
    public class User
    {
        [Key]
        [ForeignKey("Entity")]
        public int EntityId { get; set; }
        public string FirstName { get; set; }
        public virtual Entity Entity { get; set; }
}
}