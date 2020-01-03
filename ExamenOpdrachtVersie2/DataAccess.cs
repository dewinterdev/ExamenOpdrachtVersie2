using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOpdrachtVersie2
{
    public class DataAccess
    {
        public List<Person> persons = new List<Person>();

        public List<Person> GetPersons()
        {
            using (OpdrachtDbContext ctx = new OpdrachtDbContext())
            {
                try
                {
                    return ctx.Persons.ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool InsertPerson(Person person)
        {
            using (OpdrachtDbContext ctx = new OpdrachtDbContext())
            {
                try
                {
                    ctx.Persons.Add(person);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<Person> GetTheRightPerson(string firstname, string lastname)
        {
            using (OpdrachtDbContext ctx = new OpdrachtDbContext())
            {
                try
                {
                    foreach (Person i in ctx.Persons)
                    {
                        if (i.FirstName == firstname && i.LastName == lastname)
                        {
                            persons.Add(i);
                        }
                    }
                    return persons.ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        internal void Update(Person person)
        {
            using (OpdrachtDbContext ctx = new OpdrachtDbContext())
            {
                Person personDB = ctx.Persons.Where(i => i.PersonId == person.PersonId).SingleOrDefault();
                personDB.FirstName = person.FirstName;
                personDB.LastName = person.LastName;
                personDB.Gender = person.Gender;
                personDB.BirthDate = person.BirthDate;
                ctx.SaveChanges();
            }
        }
    }
}