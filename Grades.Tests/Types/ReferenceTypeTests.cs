﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {


        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            
            grades[1] = 89.1f;

        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {

            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);


        }

        private void IncrementNumber(int Number)
        {
            Number += 1;
            Number = 0;

        }



        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {

            book.Name = "A Gradebook";

        }    
            
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
