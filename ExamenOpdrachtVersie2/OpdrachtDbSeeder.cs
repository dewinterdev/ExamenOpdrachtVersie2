using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOpdrachtVersie2
{
    public class OpdrachtDbSeeder : DropCreateDatabaseAlways<OpdrachtDbContext>
    {
        protected override void Seed(OpdrachtDbContext ctx)
        {
            Person person = new Person("Han", "Dewinter", Gender.Male, new DateTime(1997, 06, 29));
            ctx.Persons.Add(person);

            ctx.SaveChanges();
        }
    }
}