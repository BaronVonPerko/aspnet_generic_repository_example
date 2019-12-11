using System.Collections.Generic;
using Data;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class DogsController : GenericController<DogsRepository, Dog>
    {
        public DogsController(CoreTestContext db)
        {
            Repository = new DogsRepository(db);
        }
    }
}