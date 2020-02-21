using System;
using FaceitAPI.Types;
using NUnit.Framework;

namespace FaceitAPI.Tests
{
    public class bearervaluegenerator_generatevalue_tests
    {
        private string Token => Guid.NewGuid().ToString();
        
        string execute(string token)
        {
            BearerValueGenerator generator = new BearerValueGenerator();
            return generator.GenerateValue(token);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(""));
        }

        [Test]
        public void returns_not_empty_string()
        {
            Assert.IsNotEmpty(execute(""));
        }

        [Test]
        public void returns_string_starts_with_Bearer()
        {
            Assert.IsTrue(execute("").StartsWith(("Bearer")));
        }

        [Test]
        public void returns_excepted_string_len()
        {
            string t = Token;
            string str = $"Bearer {t}";
            string res = execute(t);
            
            Assert.IsTrue(str.Length == res.Length);
        }

        [Test]
        public void returns_string_contains_token()
        {
            string token = Token;
            Assert.IsTrue(execute(token).Contains(token));
        }
    }
}