using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans
{
    /// <summary>
    /// Summary description for AboutAbstract
    /// </summary>
    [TestClass]
    public class AboutAbstract
    {
        /// <summary>
        /// Abstract classes have the following features:
        /// An abstract class cannot be instantiated.
        /// An abstract class may contain abstract methods and accessors.
        /// It is not possible to modify an abstract class with the sealed modifier because the two modifiers have opposite meanings.
        /// The sealed modifier prevents a class from being inherited and the abstract modifier requires a class to be inherited.
        /// A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.
        /// </summary>
        abstract class Shape
        {
            public abstract int GetArea();
        }

        class Square : Shape
        {
            int side;

            public Square(int n) => side = n;

            // GetArea method is required to avoid a compile-time error.
            public override int GetArea() => side * side;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var sq = new Square(12);
            Assert.AreEqual(0, sq.GetArea());
        }
    }
}
