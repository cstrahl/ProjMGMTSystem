using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{

    class ProjectData
    {
        private string projName;
        private Person projManager;
        private string projDescrip;
        private List<Person> projMembers;
        private List<Risk> projRisk;
        private List<Requirement> projReq;

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

        protected void setProjName ( string projName){
            this.projName = projName;
        }

        protected void setProjManager ( Person projManager){
            this.projManager = projManager;
        }

        protected void setProjDescrip (string projDescrip){
            this.projDescrip = projDescrip;
        }

        protected void setProjMembers ( List<Person> projMembers){
            this.projMembers = projMembers;
        }

        protected void setProjRisk (List<Risk> projRisk){
            this.projRisk = projRisk;
        }

        protected void setProjReq (List<Requirement> projReq){
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