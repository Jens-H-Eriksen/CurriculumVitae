using System.Collections.Generic;

namespace CvApi.Repositories
{
    public class ProjektRepository : ErfaringBaseRepository<Projekt>
    {
        public ProjektRepository()
        {
            Entities = new List<Projekt>()
            {
                new Projekt() { Id = 1, Navn = "Projekt Joakims arving" }
            };
        }
    }
}