using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{

    class ProjectData
    {

        private string projName { get; set; }
        private object projManager { get; set; }
        private string projDescrip { get; set; }
        private List<string> projMembers = new List<string>();
        private List<string> projRisk = new List<string>();
        private List<string> projReq = new List<string>();

        //private object[] projMembers { get; set; }
        //private object[] projRisk { get; set; }
        //private object[] projReq { get; set; }


        public ProjectData(string projName, object projManager, string projDescrip, List<string> projMembers, List<string> projRisk, List<string> projReq)
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