using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{
    class Risk
    {
        private string name;
        private string description;
        private string riskStatus;        

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

        public string RiskStatus
        {
            get
            {
                return this.riskStatus;
            }
            set
            {
                this.riskStatus = value;
            }
        }
    }
}
