using System.Collections.Generic;

namespace CompositeDemo
{
    internal class Group
    {
        public string Name { get; set; }
        public List<Person> Members { get; }

        public Group()
        {
            Members = new List<Person>();
        }
    }
}