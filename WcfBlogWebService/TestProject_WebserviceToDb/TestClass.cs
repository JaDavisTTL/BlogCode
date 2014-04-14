using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhibernate;
using NUnit.Framework;
using Nhibernate;
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
            repository.Insert("Kannappan","Kanna123");
            var fromDb = repository.GetById(6);
            Assert.IsNotNull(fromDb);
            
        }

        
    }
}
