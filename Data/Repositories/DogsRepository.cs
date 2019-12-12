using Data.Models;
using Perko.Generic;

namespace Data.Repositories
{
    public class DogsRepository : GenericRepository<Dog, CoreTestContext>
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