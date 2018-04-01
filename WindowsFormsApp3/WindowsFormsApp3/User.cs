using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class User
    {
        public static List<User> Istifadeci = new List<User>();
        string name;
        string surname;
        public User(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
            Istifadeci.Add(this);
        }
    }
}
