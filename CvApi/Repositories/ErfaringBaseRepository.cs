using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class ErfaringBaseRepository<TEntity> where TEntity : ErfaringBaseClass 
    {
        public List<TEntity> Entities { private get; set; }

        public Task<List<TEntity>> Get(int? id)
        {
            if (id == null)
                return Task.FromResult(Entities);

            return Task.FromResult(new List<TEntity>() { Entities.FirstOrDefault(f => f.Id == id) });
        }
    }
}