using System.Collections;
using System.Linq;
using Data.Models;

namespace Data.Repositories
{
    public class PeopleRepository : GenericRepository<Person, CoreTestContext>
    {
        public PeopleRepository(CoreTestContext db) : base(db)
        {
        }

        public override void Update(int id, Person updateObj)
        {
            var person = _db.People.Find(id);
            person.Name = updateObj.Name;
            person.Email = updateObj.Email;
            _db.People.Update(person);
            _db.SaveChanges();
        }
    }
}