using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{

    class ProjectData
    {
        private string projName { set; }
        private Person projManager {set;}
        private string projDescrip {set;}
        private List<Person> projMembers {set;}
        private List<Risk> projRisk {set;}
        private List<Requirement> projReq {set;}

        public ProjectData() { }

        public ProjectData(string projName, Person projManager, string projDescrip, List<Person> projMembers, List<Risk> projRisk, List<Requirement> projReq)
        {
            this.projName = projName;
            this.projManager = projManager;
            this.projDescrip = projDescrip;
            this.projMembers = projMembers;
            this.projRisk = projRisk;
            this.projReq = projReq;
        }

        public string getProjName()
        {
            return projName;
        }            

        public Person getProjManager(){
            return this.projManager;
        }

        public string getProjDescrip(){
            return this.projDescrip;
        }

        public List<Person> getProjMembers(){
            return this.projMembers;
        }

        public List<Person> getProjRisk(){
            return this.projRisk;
        }

        public List<Person> getProjReq(){
            return this.projReq;
        }

        public override string ToString(){
            return (projName +"\t\t"+ projManager.ToString());
        }
    }
}