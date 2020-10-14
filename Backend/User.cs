using System;
using System.Collections.Generic;
using System.Text;

namespace LoginForm.Backend
{
    [Serializable]
    class User
    {
        private string email;
        private string password;
        private bool isAdmin;

        public string Email { get { return this.email; } }
        public string Password { get { return this.password; } }
        public bool IsAdmin { get { return this.isAdmin; } }

        public User(string email, string password, bool isAdmin)
        {
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;
        }
    }
}
