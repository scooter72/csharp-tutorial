using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans
{
    [TestClass]
    public class AboutStatic
    {
        [TestMethod]
        public void TestSetStaticMemberValue()
        {
            MyClass myClass1 = new MyClass("A");
            MyClass myClass2 = new MyClass("B");

            Assert.AreEqual("A", MyClass.sampleString);
            MyClass.sampleString = "C";
            Assert.AreEqual("B", MyClass.sampleString);
        }


        class MyClass
        {
            internal static string sampleString = "Sample String";

            internal MyClass(string sampleStringValue)
            {
                sampleString = sampleStringValue;
            }
        }
    }
}
