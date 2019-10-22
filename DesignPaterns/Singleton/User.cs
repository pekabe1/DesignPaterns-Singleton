using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Singleton
{
    public class User
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        private string password;
        public bool HasAccess { get; private set; } = false;
        private static User instance;
        protected User() { }
        public static User Instance(string name, string lastName, string password)
        {
            if (instance == null)
            {
                instance = new User();            
                if (password =="abc")
                {
                    instance.Name = name;
                    instance.LastName = lastName;
                    instance.password = password;
                    instance.HasAccess = true;
                }
            }
            return instance;
        }
    }
}

