using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhibernate.DomainClasses;

namespace Nhibernate
{
    public interface IUserRepository
    {
        Users GetById(int Id);
        void UpdateUser(int ID, string Name, string password);
        void Insert(string Name, string password);


    }
}
