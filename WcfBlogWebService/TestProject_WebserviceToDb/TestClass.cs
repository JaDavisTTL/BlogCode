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
                repository.Insert("Kannappan", "Kanna123");
            }
            catch (Exception ex)
            {
                
               Console.WriteLine(ex.Message);
            }
            
            var fromDb = repository.GetById(16);
            //Assert.IsNotNull(fromDb);
            repository.UpdateUser(1,"Alan","QWERT");
            fromDb = repository.GetById(18);
            Assert.IsNotNull(fromDb);
            repository.DeleteUser(18);
            fromDb = repository.GetById(18);
            Assert.IsNull(fromDb);
        }

        
    }
}
