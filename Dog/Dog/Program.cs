using System;

namespace Prog
{
    enum Gender { Male, Female };

    class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public Dog(string Name, string Owner, int Age, Gender doggoGender)
        {
            this.name = Name;
            this.owner = Owner;
            this.age = Age;
            this.gender = doggoGender;
        }
public Dog()
        {

        }
        public void Bark(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Woof!");
            }
        }
        public string GetTag()
        {
            string HisHer = (this.gender == Gender.Male ? "His" : "Her");
            string HeShe = (this.gender == Gender.Male ? "he" : "she");
            string YearYears = (this.age == 1 ? "year" : "years");

            string returnText = "If lost, call " + this.owner + ". " + HisHer + " name is " + this.name + " and " + HeShe + " is " + this.age + " " + YearYears + " old.";
            return (returnText);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Console.WriteLine();

            var myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

            Console.ReadLine();


        }
    }
}
