using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            var otherClient = obj as Client;
            return Email.Equals(otherClient.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
