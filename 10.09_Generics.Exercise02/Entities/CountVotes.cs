using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics.Exercise02.Entities
{
    public class CountVotes
    {
        public string Name { get; set; }
        public int Quantity { get; set; }        

        public CountVotes(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CountVotes))
            {
                return false;
            }

            var countVotesOther = obj as CountVotes;
            return Name.Equals(countVotesOther.Name);
        }                
    }
}
