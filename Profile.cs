using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace СайтСистема
{
    class Profile
    {
        public string name;
        public string email;
        public int age;
        public bool isAdmin;

        public void setAll(string _name, string _email, int _age)
        {
            name = _email;
            email = _email;
            age = _age;
        }
    }
}
