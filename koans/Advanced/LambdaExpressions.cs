using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Advanced
{
    [TestClass]
    public class LambdaExpressions
    {
        [TestMethod]
        public void TestCountLines()
        {
            SandwichCode sandwich = new SandwichCode();
            int count = sandwich.CountLines("example_file.txt");
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestFindLine()
        {
            SandwichCode sandwich = new SandwichCode();
            string line = sandwich.FindLine("example_file.txt");
            Assert.AreEqual(string.Empty, line);
        }


    
        class SandwichCode
        {
            public int CountLines(string fileName)
            {
                int counter = 0;
                string line;
                StreamReader file = null;

                try
                {
                    file = new StreamReader(fileName);

                    while ((line = file.ReadLine()) != null)
                    {
                        counter++;
                    }
                }
                finally
                {
                    file.Close();
                }

                return counter;
            }


            public string FindLine(string fileName)
            {
                string line = null;
                StreamReader file = null;

                try
                {
                    file = new StreamReader(fileName);

                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.IndexOf('e') > -1)
                            return line;
                    }
                }
                finally
                {
                    file.Close();
                }

                return line;
            }

            /*
            # ------------------------------------------------------------------
            # THINK ABOUT IT:
            #
            # The CountLines and FindLine are similar, and yet different.
            # They both follow the pattern of "sandwich code".
            #
            # Sandwich code is code that comes in three parts: (1) the top slice
            # of bread, (2) the meat, and (3) the bottom slice of bread.  The
            # bread part of the sandwich almost always goes together, but
            # the meat part changes all the time.
            # Consider the following code:
           */

            public void FileByLineReader(string fileName, Func<string, bool> action) 
            {
                StreamReader file = null;

                try
                {
                    file = new StreamReader(fileName);

                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (!action(line)) break;
                    }
                }
                finally
                {
                    file.Close();
                }
            }

            public int CountLines_UsingLambda(string fileName)
            {
                int counter = 0;
                FileByLineReader(fileName, (s) => { counter++; return true; });
                return counter;
            }
        }

        [TestMethod]
        public void TestCountLines_UsingLambda()
        {
            SandwichCode sandwich = new SandwichCode();
            int count = sandwich.CountLines_UsingLambda("example_file.txt");
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestFindLine_UsingLambda()
        {
            SandwichCode sandwich = new SandwichCode();
            string line = null;
            
            sandwich.FileByLineReader("example_file.txt", (s) => 
            {
                bool found = s.Contains("e");
                if (found) 
                {
                    line = s;
                    return false;
                }
                return true;
            });
            Assert.AreEqual(string.Empty, line);
        }

    }
}
