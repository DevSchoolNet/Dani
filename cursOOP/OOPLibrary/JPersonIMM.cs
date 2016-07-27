using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class JPersonIMM : Customer
    {
        public override void MakeRequest(string Name, string CNPorCUI)
        {
            throw new System.NotImplementedException();
        }

        public override void MakeCard(string Name, string CNPorCUI)
        {
            throw new System.NotImplementedException();
        }

        public void MakeCard(IndividualPerson person)
        {
            throw new System.NotImplementedException();
        }
    }
}