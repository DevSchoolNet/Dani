using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary {
    public class FrontOffice : Employee, IFrontOffice {
        public void AddCustomer(string name, string CNP) {
            throw new System.NotImplementedException();
        }

        public bool OpenRelation(string name, string CNP) {
            throw new System.NotImplementedException();
        }
    }
}