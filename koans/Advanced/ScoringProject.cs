using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans.Advanced
{
    /*
        # Greed is a dice game where you roll up to five dice to accumulate
        # points.  The following "score" function will be used to calculate the
        # score of a single roll of the dice.
        #
        # A greed roll is scored as follows:
        #
        # * A set of three ones is 1000 points
        #
        # * A set of three numbers (other than ones) is worth 100 times the
        #   number. (e.g. three fives is 500 points).
        #
        # * A one (that is not part of a set of three) is worth 100 points.
        #
        # * A five (that is not part of a set of three) is worth 50 points.
        #
        # * Everything else is worth 0 points.
        #
        #
        # Examples:
        #
        # score([1,1,1,5,1]) => 1150 points
        # score([2,3,4,6,2]) => 0 points
        # score([3,4,5,3,3]) => 350 points
        # score([1,5,1,2,4]) => 250 points
        #
        # More scoring examples are given in the tests below:
        #
        # Your goal is to write the score method.
    */
    
    [TestClass]
    public class ScoringProject
    {
        public int Score(int[] dice)
        {
            //  -- You need to write this method --

            return -1;
        }

        [TestMethod]
        public void Test_Score_Of_An_Empty_List_Is_Zero()
        {
            Assert.AreEqual(0, Score(new int[0]));
        }

        [TestMethod]
        public void Test_Score_Of_A_Single_Roll_Of_5_Is_50()
        {
            Assert.AreEqual(50, Score(new int[5]));
        }

        [TestMethod]
        public void Test_Score_Of_A_Single_Roll_Of_1_Is_100()
        {
            Assert.AreEqual(50, Score(new int[1]));
        }
        
        [TestMethod]
        public void Test_Score_Of_multiple_1s_and_5s_is_the_sum_of_individual_scores()
        {
            Assert.AreEqual(300, Score(new int[] { 1, 5, 5, 1 }));
        }

        [TestMethod]
        public void Test_Score_Of_single_2s_3s_4s_and_6s_are_zero()
        {
            Assert.AreEqual(0, Score(new int[] { 2, 3, 4, 6 }));
        }


        [TestMethod]
        public void Test_Score_Of_a_triple_1_is_1000()
        {
            Assert.AreEqual(1000, Score(new int[] { 1, 1, 1 }));
        }

        [TestMethod]
        public void Test_Score_Of_other_triples_is_100x()
        {
            Assert.AreEqual(200, Score(new int[] { 2, 2, 2 }));
            Assert.AreEqual(300, Score(new int[] { 3, 3, 3 }));
            Assert.AreEqual(400, Score(new int[] { 4, 4, 4 }));
            Assert.AreEqual(500, Score(new int[] { 5, 5, 5 }));
            Assert.AreEqual(600, Score(new int[] { 6, 6, 6 }));
        }

        [TestMethod]
        public void Test_Score_Of__mixed_is_sum()
        {
            Assert.AreEqual(250, Score(new int[] { 2, 5, 2, 2, 3 }));
            Assert.AreEqual(550, Score(new int[] { 5, 5, 5, 5 }));
            Assert.AreEqual(1100, Score(new int[] { 1, 1, 1, 1 }));
            Assert.AreEqual(1200, Score(new int[] { 1, 1, 1, 1, 1 }));
            Assert.AreEqual(1150, Score(new int[] { 1, 1, 1, 5, 1 }));
        }
    }
}
