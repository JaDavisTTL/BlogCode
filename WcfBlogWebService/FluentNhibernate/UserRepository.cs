using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Nhibernate.DomainClasses;

namespace Nhibernate
{
    public class UserRepository : IUserRepository
    {
        
        public int Maxid()
        {

            using (ISession session = NHibernateHelper.OpenSession())
                return (int)session.Query<Users>().Max(x => (int?) x.ID);
        }
        public Users GetById(int Id)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<Users>(Id);
            }


            catch (Exception e)
            {

                throw e;
            }

        }

        public void Insert(string Name, string password)
        {
            var User1 = new Users()
                {
                    UserName = Name,
                    Password = password
                };
            // And save it to the database
            using (ISession session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(User1);
                    transaction.Commit();
                }
                catch (Exception e)
                {

                    throw e;
                }

            }

        }

        public void UpdateUser(int ID, string Name, string password)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        var singleUser = session.Load<Users>(ID);
                        singleUser.UserName = Name;
                        singleUser.Password = password;
                        transaction.Commit();
                    }
                }
            }
            catch (ObjectNotFoundException)
            {
                throw new Exception("No records found for the given ID.");
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        public void DeleteUser(int ID)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var singleUser = session.Load<Users>(ID);
                        session.Delete(singleUser);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

    }
}
