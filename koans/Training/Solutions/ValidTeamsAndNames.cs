using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans.Training.Solutions
{
    public class ValidTeamsAndNames
    {
        public static string Validate(string input)
        {
            string[] tokens = input.Split(':');
            var numOfTeams = 0;
            List<string> users = new List<string>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if ((tokens[i].Length == 1) || tokens[i].Split(',').Length == 1) continue;
                var members = tokens[i].Split(',');

                var lastMember = members[members.Length - 1];

                if (char.IsUpper(lastMember.ToCharArray()[lastMember.Length - 1]))
                {
                    members[members.Length - 1] = lastMember.Substring(0, lastMember.Length - 1);
                }

                foreach (var m in members)
                {
                    users.Add(m);
                }

                numOfTeams++;
            }

            var usersStr = string.Join(",", users.ToArray());
            return $"{numOfTeams}:{usersStr}";

        }

    }
}
