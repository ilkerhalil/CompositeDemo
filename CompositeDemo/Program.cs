using System;
using System.Collections.Generic;

namespace CompositeDemo
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var goldForKill = 1023;
            Console.WriteLine($"You have killed the Giant IE6 Monster and gained {goldForKill} gold");

            var joe = new Person { Name = "Joe" };

            var jake = new Person { Name = "Jake" };

            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };

            var brian = new Person { Name = "Brain" };

            var developers = new Group { Name = "Developers", Members = { joe, jake, emily } };

            var individuals = new List<Person> { sophia, brian };
            var groups = new List<Group> { developers };
            var totalToSplitBy = individuals.Count + groups.Count;
            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill / totalToSplitBy;
            foreach (var individual in individuals)
            {
                individual.Gold += amountForEach + leftOver;
                leftOver = 0;
                individual.Stats();
            }
            foreach (var @group in groups)
            {
                var amoutForEachGroupMember = amountForEach/group.Members.Count;
                var leftOverForGroup = amoutForEachGroupMember%group.Members.Count;
                foreach (var member in @group.Members)
                {
                    member.Gold += amoutForEachGroupMember + leftOverForGroup;
                    leftOverForGroup = 0;
                    member.Stats();
                }
            }
            Console.ReadKey();

        }
    }
}
