using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //private DataGridView projTracking;

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

        internal void setProjName (string projName){
            this.projName = projName;
        }

        internal void setProjManager (Person projManager){
            this.projManager = projManager;
        }

        internal void setProjDescrip (string projDescrip){
            this.projDescrip = projDescrip;
        }

        internal void setProjMembers (List<Person> projMembers){
            this.projMembers = projMembers;
        }

        internal void setProjRisk (List<Risk> projRisk){
            this.projRisk = projRisk;
        }

        internal void setProjReq (List<Requirement> projReq){
            this.projReq = projReq;
        }

        //internal void setProjTracking (DataGridView projTracking){
        //    this.projTracking = projTracking;
        //}

        //public DataGridView getProjTracking(){
        //    return projTracking;
        //}

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

        public List<Risk> getProjRisk(){
            return this.projRisk;
        }

        public List<Requirement> getProjReq(){
            return this.projReq;
        }

        public override string ToString(){
            return (projName +"\t\t"+ projManager.ToString());
        }
    }
}