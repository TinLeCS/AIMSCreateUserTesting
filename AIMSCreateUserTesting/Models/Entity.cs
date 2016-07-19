using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMSCreateUserTesting.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
    }
}