using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary {
    public class Employee : User {
        public int Wage {
            get {
                throw new System.NotImplementedException();
            }

            set {
            }
        }

        public string EmployeeId {
            get {
                throw new System.NotImplementedException();
            }

            set {
            }
        }

        public string Department {
            get {
                throw new System.NotImplementedException();
            }

            set {
            }
        }

        public override void Login(string employeeId, string password) {
            throw new System.NotImplementedException();
        }

        public void Login(string name, string employeeId, string password) {
            base.Login(name, password);
            //codul nostru
        }

    }
}