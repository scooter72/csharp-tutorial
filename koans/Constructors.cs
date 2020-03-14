using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    /// <summary>
    /// Summary description for Constructors
    /// </summary>
    [TestClass]
    public class Constructors
    {
        [TestMethod]
        public void TestConstructorWithArguments()
        {
            Car car = new Car();
            Assert.AreEqual("Mustang", car.Model);
            Assert.AreEqual("Red", car.Color);
        }
    }

    class Car
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        
         internal Car() : this(string.Empty, "White") { }

        Car(string model, string color) 
        {
            Model = model;
            Color = color;
        }
    }
}
