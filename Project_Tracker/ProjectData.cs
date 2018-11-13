using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{

    class ProjectData
    {
        public string projName { get; set; }
        private object projManager { get; set; }
        private string projDescrip { get; set; }
        private List<Person> projMembers = new List<Person>();
        private List<Risk> projRisk = new List<Risk>();
        private List<Requirement> projReq = new List<Requirement>();

        public ProjectData() { }

        public ProjectData(string projName, object projManager, string projDescrip, List<Person> projMembers, List<Risk> projRisk, List<Requirement> projReq)
        {
            this.projName = projName;
            this.projManager = projManager;
            this.projDescrip = projDescrip;
            this.projMembers = projMembers;
            this.projRisk = projRisk;
            this.projReq = projReq;

        }

        public override string ToString(){
            return (projName +"\t\t"+ projManager.ToString());
        }
    }
}