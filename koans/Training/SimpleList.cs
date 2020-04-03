using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// Implement the IList interface to create a simple, fixed-size list.
    /// </summary>
    [TestClass]
    public class SimpleList : IList
    {
        //
        // Summary:
        //     Gets or sets the element at the specified index.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the element to get or set.
        public object this[int index] 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public int Count => throw new NotImplementedException();
        
        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestAdd()
        {
            IList list = new SimpleList();
            list.Add(1);
            // to support index access you need to implement
            Assert.AreEqual(1, list[0]);
        }

        [TestMethod]
        public void TestRemove()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Remove(1);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Add(2);
            list.RemoveAt(0);
            Assert.AreEqual(2, list[0]);
        }

        [TestMethod]
        public void TestInsert()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Insert(0, 2);
            list.RemoveAt(0);
            Assert.AreEqual(2, list[0]);
        }

        [TestMethod]
        public void TestIndexOf()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(1, list.IndexOf(2));
        }

        [TestMethod]
        public void TestCopyTo()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] expected = new int[] { 1, 2, 3 };
            int[] actual = new int[3];
            list.CopyTo(actual, 0);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void TestContains()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.IsTrue(list.Contains(2), "list does not contain the element: " + 2);
        }

        [TestMethod]
        public void TestClear()
        {
            IList list = new SimpleList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();
            Assert.IsTrue(list.Count == 0, "list shoud be empty");
        }

        #region igopre
        public bool IsReadOnly => false;

        public bool IsFixedSize => true;

        public object SyncRoot => this;

        public bool IsSynchronized => false;

        // ignore not tested
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
