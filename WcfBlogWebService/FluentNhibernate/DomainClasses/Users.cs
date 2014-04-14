using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhibernate.DomainClasses
{
    public class Users
    {
        public virtual int ID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
    }
}
