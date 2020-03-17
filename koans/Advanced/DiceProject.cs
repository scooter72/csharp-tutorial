using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans.Advanced
{
    [TestClass]
    public class DiceProject
    {
        class DiceSet
        {
            private int[] values = new int[0];

            public int[] Values 
            { 
                get 
                {
                    return values;
                } 
            }

            internal void roll(int times)
            { 
            }
        }

        [TestMethod]
        public void Test_rolling_the_dice_returns_a_set_of_integers_between_1_and_6()
        {
            DiceSet dice = new DiceSet();
            dice.roll(5);
            Assert.AreEqual(5, dice.Values.Length);
            Assert.IsFalse(dice.Values.Any(i => i < 1 || i > 6), "values must be between 1 and 6");
        }

        [TestMethod]
        public void Test_dice_values_do_not_change_unless_explicitly_rolled()
        {
            DiceSet dice = new DiceSet();
            dice.roll(5);
            int[] firstTime = dice.Values;
            int[] secondTime = dice.Values;

            // un-comment after you implement the DiceSet class
            // Assert.IsTrue(firstTime.SequenceEqual(secondTime));
            Assert.IsTrue(false, "un-comment after you implement the DiceSet class");
        }

        [TestMethod]
        public void Test_dice_values_should_change_between_rolls()
        {
            DiceSet dice = new DiceSet();
            dice.roll(5);
            int[] firstTime = dice.Values;

            dice.roll(5);
            int[] secondTime = dice.Values;

            // un-comment after you implement the DiceSet class
            // Assert.IsTrue(firstTime.SequenceEqual(secondTime));
            Assert.IsTrue(false, "Two rolls should not be equal");

            /*
                # THINK ABOUT IT:
                #
                # If the rolls are random, then it is possible (although not
                # likely) that two consecutive rolls are equal
             */
        }

        [TestMethod]
        public void Test_you_can_roll_different_numbers_of_dice()
        {
            DiceSet dice = new DiceSet();
            dice.roll(3);
            Assert.AreEqual(3, dice.Values.Length);
            dice.roll(1);
            Assert.AreEqual(1, dice.Values.Length);
        }

    }
}
