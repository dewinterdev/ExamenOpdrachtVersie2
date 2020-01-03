using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOpdrachtVersie2
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public Person()
        {
        }

        public Person(int personId, string firstname, string lastname, Gender gender, DateTime birthDate) : this(firstname, lastname, gender, birthDate)
        {
            PersonId = personId;
        }

        public Person(string firstname, string lastname, Gender gender, DateTime birthDate)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            BirthDate = birthDate;
        }

        public static List<Person> GetPersons()
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.GetPersons();
        }

        public bool InsertPerson()
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.InsertPerson(this);
        }

        public static List<Person> GetTheRightPerson(string firstname, string lastname)
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.GetTheRightPerson(firstname, lastname);
        }

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }

        public void UpdateDB()
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.Update(this);
        }
    }
}