using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {

        [TestMethod]
        public void VariiablesHoldReference()
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g2.Name = "Ryan's Compendium of Awesomeness";
            Console.WriteLine(g1.Name);

            Assert.AreEqual(g1.Name, g2.Name);
        }


    }
}
