

namespace Project_Tracker{

    class Person{
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public override string ToString(){
            return (firstName + " " + lastName);
        }

    }
}