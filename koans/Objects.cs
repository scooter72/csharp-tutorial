using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Objects
    {

        [TestMethod]
        public void TestString()
        {
            // create string object
            string s1 = new string("123".ToCharArray());
            string s2 = string.Empty;

            Assert.AreEqual( s1, s2);
        }

        [TestMethod]
        public void TestObjectCanBeConvertedToString()
        {
            object myObj = new MyObject();

            Assert.AreEqual("", myObj.ToString());
        }

        [TestMethod]
        public void TestAccessObjectMember()
        {
            MyObject myObj = new MyObject();

            Assert.AreEqual("", myObj.Value);
        }

        [TestMethod]
        public void TestAccessObjectVoidMethod()
        {
            Controller controller = new Controller();
            MyObject myObj = new MyObject();
            controller.SetValue(myObj, string.Empty);

            Assert.AreEqual("FILL ME IN", myObj.Value);
        }

        [TestMethod]
        public void TestAccessObjectMethod()
        {
            Controller controller = new Controller();
            MyObject myObj = controller.CreateObject("foo bar");

            Assert.AreEqual("", myObj.Value);
        }

        [TestMethod]
        public void TestAnObjectHashcode()
        {
            // create string object
            object myObj = new MyObject();

            Assert.AreEqual(typeof(object), myObj.GetHashCode().GetType());
        }

        [TestMethod]
        public void TestObjectsHasUniqueId()
        {
            // create string object
            object myObj = new MyObject();
            object myObj2 = new MyObject();
            
            Assert.IsTrue(myObj.GetHashCode() == myObj2.GetHashCode());
        }

        class MyObject 
        {
            private string _value = "Hello World";

            public String Value 
            { 
                get 
                { 
                    return _value; 
                }

                set
                {
                    _value = value;
                }
            }

            public override string ToString()
            {
                return Value;
            }
        }

        class Controller
        {
            public MyObject CreateObject(string value)
            {
                return new MyObject { Value = value };
            }

            public void SetValue(MyObject myObject, string value)
            {
                myObject.Value = value;
            }
        }

    }
}
