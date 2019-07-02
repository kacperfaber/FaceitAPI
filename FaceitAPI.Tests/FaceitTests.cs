using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using NUnit;
using NUnit.Framework;

namespace FaceitAPI.Tests
{
    public class FaceitTests
    {
        private Faceit Get()
        {
            return new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
        }

        [Test]
        public void ConstructorNotThrowsExceptionWhenValid()
        {
            Assert.DoesNotThrow(() => new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47")));
        }

        [Test(Author = "Kacpii", Description = "Hello")]
        public void ConstructorThrowsExceptionWhenAuthorizationIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Faceit(null));
        }

        [Test]
        public void GetObjectNotThrowsExceptions()
        {
            Assert.DoesNotThrow(() => { Get().GetObject<Search>(); } );
        }

        [Test]
        public void GetObjectReturnsTheSameObject()
        {
            Faceit f = Get();

            Search search1 = f.GetObject<Search>();
            search1.Deserializer = null;

            Search search2 = f.GetObject<Search>();

            Assert.AreEqual(search1, search2);
        }

        [Test]
        public void ResponseIsNotEmpty()
        {
            // arrange
            string json = "";

            Search s = Get().GetObject<Search>();
            s.Response = new Response((x, y) => { Console.WriteLine(x); json = x; });

            // act
            s.GetPlayers("Kacperf1234", "csgo", "pl");
            
            // assert
            Assert.IsNotEmpty(json);
        }
    }
}
