using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{
    class Requirement
    {
        private string name;
        private string description;
        private bool functional;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public bool Functional
        {
            get
            {
                return this.functional;
            }
            set
            {
                this.functional = value;
            }
        }

        public Requirement(string name, string description, bool functional)
        {
            this.name = name;
            this.description = description;
            this.functional = functional;
        }
    }
}
