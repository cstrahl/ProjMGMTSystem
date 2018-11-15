

namespace Project_Tracker{

    class Person{
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }

        protected void setFirstName ( string firstName){
            this.firstName = firstName;
        }

        protected void setLastName ( string lastName){
            this.lastName = lastName;
        }

        public string getFirstName(){
            return firstName;
        }

        public string getLastName(){
            return lastName;
        }

        public override string ToString(){
            return (firstName + " " + lastName);
        }

    }
}