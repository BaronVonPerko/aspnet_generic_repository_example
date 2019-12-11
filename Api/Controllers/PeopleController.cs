using System.Collections.Generic;
using Data;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class PeopleController : GenericController<PeopleRepository, Person>
    {
        public PeopleController(CoreTestContext db)
        {
            Repository = new PeopleRepository(db);
        }
    }
}