using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhibernate;
using NUnit.Framework;
using Nhibernate.DomainClasses;


namespace TestProject_WebserviceToDb
{ 
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Can_get_existing_customer_by_id()
        {

            UserRepository repository = new UserRepository();
            try
            {
                repository.Insert("NewDB", "Kanna123");
            }
            catch (Exception ex)
            {
                
               Console.WriteLine(ex.Message);
            }

            var maxid = repository.Maxid();
            var fromDb = repository.GetById(maxid);
            Assert.IsNotNull(fromDb);
            repository.UpdateUser(maxid, "Alan", "QWERT");
            fromDb = repository.GetById(maxid);
            Assert.IsTrue(fromDb.UserName=="Alan");
            repository.DeleteUser(maxid);
            fromDb = repository.GetById(maxid);
            Assert.IsNull(fromDb);
        }

        
    }
}
