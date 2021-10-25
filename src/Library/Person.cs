using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string date)
        {
            this.Name = name;
            this.ID = id;
            this.BornDate = date;
        }

        private string borndate;
        private string name;

        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string BornDate
        {
            get
            {
                return this.borndate;
            }
            
            set
            {   
                string[] date = value.Split('/');

                if (Int32.Parse(date[0])  < 31 && Int32.Parse(date[0]) > 1 &&  Int32.Parse(date[1]) > 1 && Int32.Parse(date[1]) < 12 && Int32.Parse(date[2]) > 1900)
                {
                    this.borndate = value;
                }
            }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID} y su fecha de nacimiento es {this.BornDate}");
        }
    }
}
