using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student : Person, IComparable
    {




        public Student(string name, string lastName, string location, string email)
            : base(name, lastName)
        {
            this.email = email;
            this.Location = location;
        }

        public Student(string name, string lastName, string email)
            : base(name, lastName)
        {
            this.email = email;
        }

        public Student()
            : base("", "")
        { }

        ~Student()
        {
        }

        public string email
        {
            get;
            set;
        }

        private string location;
        public string Location
        {
            set
            {
                // Program ce izbaciti samo gradove Tuzla i Sarajevo , dok ce odstali biit "other"

                if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo") location = "SA";
                else
                {

                    if (value == "TZ" || value.Equals("Tuzla", StringComparison.OrdinalIgnoreCase)) location = "TZ";
                    else
                        location = "NA";
                }


            }
            get
            {

                if (location == "SA") return "Sarajevo";
                else
                    if (location == "TZ") return "Tuzla";
                    else
                        return "Other";
            }
        }

        public bool setName(string input)
        {

            if (input.Length < 2)
            {

                Console.WriteLine("Name must be at least two characters long");

                return false;

            }


            char[] chars = input.ToCharArray();
            foreach (char c in chars)
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("Name can only have letters");
                    return false;
                }
            }



            if (input.First().ToString().ToUpper() != input.First().ToString())
            {

                Console.WriteLine("Name must start with an uppercase letter"); return false;

            }

            name = input;
            return true;

        }

        public string getStudentInfo()
        {
            string studentinfo = getPersonInfo();
            studentinfo = studentinfo + email + ", " + Location;
            return studentinfo;
        }



        public int CompareTo(object obj)
        {
            Student student = (Student)obj;

            if (location == "NA")
            {
                if (student.location == "NA") return 0;
                else return -1;
            }
            else if (location == "SA")
            {

                if (student.location == "SA") return 0;
                else if (student.location == "NA") return 1;
                else return -1;
            }
            else
            {
                if (location == student.location) return 0;
                else return 1;
            }


        }


        public override string ToString()
        {

            return getStudentInfo();
        }
    }
}
