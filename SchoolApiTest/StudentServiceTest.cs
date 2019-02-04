using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiTest
{
    [TestFixture]
    public class StudentServiceTest
    {
        [Test]
        public void Test_Addition()
        {
            var number = 1;
            Assert.AreEqual(2, number);
        }
    }
}
