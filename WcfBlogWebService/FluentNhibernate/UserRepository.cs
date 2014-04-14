using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Nhibernate.DomainClasses;

namespace Nhibernate
{
    public class UserRepository : IUserRepository
    {
        
        public Users GetById(int Id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Users>(Id);

        }

        public void Insert(string Name, string password)
        {
             
            // Create a Person...
            var User1 = new Users()
            {
                
                UserName = Name,
                Password = password
            };

            

            // And save it to the database
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(User1);
                    //NHibernateHelper.OpenSession().Flush();
                    transaction.Commit();
                }
                catch (Exception exception)
                {
                        
                    throw;
                }
                
            }
            
        }
    }
}
