using System.Collections.Generic;
using System.Linq;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class ErfaringBaseRepository<TEntity> where TEntity : ErfaringBaseClass 
    {
        public List<TEntity> Entities { private get; set; }

        public List<TEntity> Get(int? id)
        {
            if (id == null)
                return Entities;

            return new List<TEntity>() { Entities.FirstOrDefault(f => f.Id == id) };
        }
    }
}