using System.Collections;
using System.Linq;
using Data.Models;

namespace Data.Repositories
{
    public class DogsRepository : GenericRepository<Dog>
    {
        public DogsRepository(CoreTestContext db) : base(db)
        {
        }

        public override void Update(int id, Dog updatedObj)
        {
            var dog = _db.Dogs.Find(id);
            dog.Name = updatedObj.Name;
            dog.Birthdate = updatedObj.Birthdate;
            _db.Update(dog);
            _db.SaveChanges();
        }
    }
}