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
        public void StringComparisons()
        {

            string name1 = "Ryan";
            string name2 = "ryan";



            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);


        }



        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void GradeBookVariablesHoldReference()
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g2.Name = "Ryan's Compendium of Awesomeness";
            Console.WriteLine(g1.Name);

            Assert.AreEqual(g1.Name, g2.Name);
        }


    }
}
