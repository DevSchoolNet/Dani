using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public abstract class Customer : User
    {
        public Customer()
        {
            throw new System.NotImplementedException();
        }

        protected string CNPorCUI
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public abstract void MakeRequest(string Name, string CNPorCUI);

        public abstract void MakeCard(string Name, string CNPorCUI);      
    }
}