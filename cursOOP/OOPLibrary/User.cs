using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary {
    public class User : IUser {

        private static int users = 0;

        public static int GetUsers() {
            return users;
        }
        public User() {
            Name = "John";
            users++;
        }

        public User(string name) {
            Name = name;
            users++;
        }

        ~User() {
            users--;
        }

        public string Name
        {
            get; private set; }

        private string password;
        public string Password { get; }

        public string Email
        {
            get; set; }

        public virtual void Login(string name, string password) {
            throw new System.NotImplementedException();
        }

        public void Logout() {
            throw new System.NotImplementedException();
        }
    }
}