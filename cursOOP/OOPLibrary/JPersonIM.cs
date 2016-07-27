using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class JPersonIM : Customer
    {
        public BaxkOffice EmployeeBO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override void MakeRequest(string Name, string CNPorCUI)
        {
            throw new System.NotImplementedException();
        }

        public override void MakeCard(string Name, string CNP)
        {
            throw new System.NotImplementedException();
        }
        public void MakeCard(IndividualPerson person)
        {

        }
    }
}