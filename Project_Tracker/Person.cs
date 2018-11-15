

namespace Project_Tracker{

    class Person{
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }

        internal void setFirstName ( string firstName){
            this.firstName = firstName;
        }

        internal void setLastName ( string lastName){
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