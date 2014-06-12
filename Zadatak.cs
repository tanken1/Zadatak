using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Person
    {
        // Vlasnik projekta 
        protected string signature = "Ismar Dzanko - CITA180 Project";
        protected string name, lastName;
        private static int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }


        public Person(string name, string lastName)
        {
            count++;
            this.name = name;
            this.lastName = lastName;

        }

        public string getPersonInfo() { return name + ", " + lastName; }


        ~Person()
        {
            count--;
        }

    };

     

    class Task
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            // Lista studenata ( imena,prezimena i grad )
            List<Student> list = new List<Student>{
            new Student("Ismar", "Dzanko", "Sarajevo", ""),
            new Student("Dino", "Eminagic", "Bihac", ""),
            new Student("Dzan", "Operta", "Tuzla", ""),
            new Student("Dzan", "Torljak", "Neum", ""),
            new Student("Emir", "Abispahic", "Tuzla", ""),
            new Student("Armin", "Terbal", "Brcko", ""),
            new Student("Armin", "Bijedic", "Sarajevo", ""),
            new Student("Ermin", "Osim", "Sarajevo", ""),
            new Student("Tarik", "Kruscica", "Brcko", ""),
            new Student("Erdal", "Jordamovic", "Gorazde", ""),           
            new Student("Haris", "Omeragic", "Zenica", "")
            };

            list.Sort();
            foreach (Student s in list)
            {
                counter++;
                Console.WriteLine(counter + " " + s.ToString());
            }


            Console.ReadKey();
        }
    }
}
