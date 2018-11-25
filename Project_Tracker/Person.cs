

namespace Project_Tracker{

    class Person{
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName) {
            this.firstName = firstName;
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
            try
            {
                return (firstName + " " + lastName);
            }
            catch {
                return (firstName);
            }
            
        }

    }
}