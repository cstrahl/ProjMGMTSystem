

namespace Project_Tracker{

    class Person{
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }


        override ToString(){
            return (firstName + " " + lastName);
        }

    }
}