using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /*
     You are in an IT company which has multiple teams. 
     You will be given a string listing teams together with their members. Each entry starts with a capital letter, 
     followed by a colon, and a comma-separated list of workers' names. The entries themselves are not separated by anything.
     A valid team must include at least 2 workers. You have to calculate how many valid teams this company has, and list the 
     names of their members in the format: {N_OF_VALID_TEAMS}:{COMMA_SEPARATED_NAMES}.
     Note: there will always be at least 1 valid team.
     Examples:
     s = "A:Stefan,Milica,Zvonimir,AndrewH:Richard"
     mix(s) == "1:Stefan,Milica,Zvonimir,Andrew"
     s = "W:John,John,John,JohnC:Danger,Man"
     mix(s) == "2:John,John,John,John,Danger,Man"
    */
    [TestClass]
    public class ValidTeamsAndNames
    {

        private static string Validate(string input)
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SampleTest1()
        {
            String actual = ValidTeamsAndNames.Validate("A:Stefan,Milica,Zvonimir,AndrewH:Richard");
            String expected = "1:Stefan,Milica,Zvonimir,Andrew";
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void SampleTest2()
        {
            String actual = ValidTeamsAndNames.Validate("W:John,John,John,JohnC:Danger,Man");
            String expected = "2:John,John,John,John,Danger,Man";
            Assert.AreEqual(expected, actual);
        }

        private static readonly Random random = new Random();
        private static readonly char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly string[] names = new string[]{"Emma", "Olivia", "Ava", "Isabella", "Sophia",
                    "Charlotte", "Mia", "Amelia", "Harper", "Evelyn", "Abigail", "Emily", "Elizabeth",
                    "Mila", "Ella", "Avery", "Sofia", "Camila", "Aria", "Scarlett", "Liam", "Noah",
                    "William", "James", "Oliver", "Benjamin", "Elijah", "Lucas", "Mason", "Logan",
                    "Alexander", "Ethan", "Jacob", "Michael", "Daniel", "Henry", "Jackson", "Sebastian",
                    "Aiden", "Matthew"};

        [TestMethod]
        public void RandomTests()
        {
            for (int i = 0; i < 100; i++)
            {
                StringBuilder sb = new StringBuilder();
                char[] shuffled = Shuffle(alphabet);
                int teams = random.Next(26);
                int guaranteedTeam = random.Next(teams + 1);
                for (int j = teams; j >= 0; j--)
                {
                    sb.Append(shuffled[j]);
                    sb.Append(':');
                    for (int k = random.Next(5) + (j == guaranteedTeam ? 1 : 0); k >= 0; k--)
                    {
                        sb.Append(names[random.Next(names.Length)]);
                        if (k > 0) sb.Append(',');
                    }
                }
                string s = sb.ToString();
                Assert.AreEqual(Solutions.ValidTeamsAndNames.Validate(s), ValidTeamsAndNames.Validate(s));
            }
        }

        private static char[] Shuffle(char[] a)
        {
            for (int i = a.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = a[j];
                a[j] = a[i];
                a[i] = temp;
            }
            return a;
        }
    }
}
