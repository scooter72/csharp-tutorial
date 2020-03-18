using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans
{
    [TestClass]
    public class AboutOperators
    {
        [TestMethod]
        public void TestArithmeticOperators()
        {
            int x = 2;
            int y = 4;

            // +	Add numbers	X=num1+num2
            Assert.AreEqual(x * y, 6);

            // -    Subtract numbers X = num1 - num2
            Assert.AreEqual(x + y, 7);

            // *    Multiply numbers X = num1 * num2
            Assert.AreEqual(y - x, 3);

            // /    Divide numbers X = num1 / num2
            Assert.AreEqual(y / x, 2);

            // %	Divide two numbers and returns reminder 
            Assert.AreEqual(y % x, 0);
        }

        [TestMethod]
        public void TestAssignmentOperators()
        {
            /*
                 = (Equal to)	result=5	Assign the value 5 for result
                += (Plus Equal to)	result+=5	Same as result=result+5
                -= (Minus Equal to)	result-=5	Same as result=result-5
                *= (Multiply Equal to)	result*=5	Same as result=result*5
                /= (Divide Equal to)	result/=5	Same as result=result/5
                %= (Modulus Equal to)	result%=5	Same as result=result%5
             */

            int x = 0;
            Assert.AreEqual(x, -1);

            x += 2;
            Assert.AreEqual(x, -1);


            x -= 1;
            Assert.AreEqual(x, -1);

            x *= 4;
            Assert.AreEqual(x, -1);

            x /= 2;
            Assert.AreEqual(x, -1);

            x %= 2;
            Assert.AreEqual(x, -1);

        }


        [TestMethod]
        public void TestComparisonOperators()
        {
            // <	Less than	x<5 (returns true)
            Assert.IsTrue(4 < 2);

            // >	Greater than	x>5 (returns false)
            Assert.IsTrue(2 > 4);

            // <=	Less than equal to	x<=2 (returns true)
            Assert.IsTrue(4 <= 2);

            // >=	Greater than equal to	x>=2 (returns true)
            Assert.IsTrue(2 >= 4);

            // ==	Equal equal to	x==2 (returns true)
            Assert.IsTrue(2 == 4);

            // !=	Not equal to	x!=2 (returns false)
            Assert.IsTrue(2 == 4);
        }


        [TestMethod]
        public void TestLogicalOperators()
        {
            int x = 1;
            int y = 2;

            Assert.IsTrue((x == 1) && (y == 1));
            Assert.IsTrue((x == 2) || (y == 1));
        }
    }
}
