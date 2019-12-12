using System.Collections.Generic;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class GenericController<TRepo, TModel> : ControllerBase where TRepo : IGenericRepository<TModel>
    {
        protected TRepo Repository;

        [HttpGet]
        public List<TModel> GetAll()
        {
            return (List<TModel>) Repository.GetAll();
        }
        
        [HttpGet]
        [Route("{id}")]
        public TModel GetSingle(int id)
        {
            return Repository.GetSingle(id);
        }
        
        [HttpPost]
        public void Insert([FromForm] TModel newObj)
        {
            Repository.Insert(newObj);
        }
        
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Repository.Delete(id);
        }
        
        [HttpPut]
        [Route("{id}")]
        public void Update(int id, [FromForm] TModel updateObj)
        {
            Repository.Update(id, updateObj);
        }
    }
}