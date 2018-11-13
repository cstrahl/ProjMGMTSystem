

namespace Project_Tracker{

    static class ProjectData{

        private string projName { get; set; }
        private object projManager { get; set; }
        private string projDescrip { get; set; }
        private object[] projMembers { get; set; }
        private object[] projRisk { get; set; }
        private object[] projReq { get; set; }


        public ProjectData(string projName, object projManager, string projDescrip, object[] projMembers, object[] projRisk, object[] projReq){
            this.projName = projName;
            this.projManager = projManager;
            this.projDescrip = projDescrip;
            this.projMembers = projMembers;
            this.projRisk = projRisk;
            this.projReq = projReq;

        }


    }
}