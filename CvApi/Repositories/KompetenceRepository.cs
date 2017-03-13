using System.Collections.Generic;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class KompetenceRepository : ErfaringBaseRepository<Kompetence>
    {
        public KompetenceRepository()
        {
            Entities = new List<Kompetence>()
            {
                new Kompetence() { Id = 1, Navn = "Dovneri" },
                new Kompetence() { Id = 2, Navn = "Raserianfald" }
            };
        }
    }
}