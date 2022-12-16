using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.dev.Objects
{
    class User
    {
        private string username;
        private string name;
        private string surname;
        private Post post;

        public User(string username, string name, string surname, Post post)
        {
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.post = post;
        }
    }
}
