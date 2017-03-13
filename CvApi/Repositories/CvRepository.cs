using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class CvRepository
    {
        private readonly Cv _cv = new Cv()
        {
            Overskrift = "*** Curriculum Vitae ***",
            Navn = "Anders And",
            Alder = 82,
            Resume = "Har mange års erfaring med dovneri i hængekøje, samt pudsning af mønter. Kan til tider blive meget ophidset og har det med at komme galt afsted",
        };


        public Task<Cv> Get()
        {
            return Task.FromResult(_cv);
        }

    }


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


    public class FirmaRepository : ErfaringBaseRepository<Firma>
    {
        public FirmaRepository() 
        {
            Entities = new List<Firma>()
                                {
                                    new Firma() {Id = 1, Navn = "Von Ands pengetank", Beskrivelse = "Pudsning af flere fantasilliarder mønter"},
                                    new Firma() {Id = 2, Navn = "Smørfabrikken"},
                                    new Firma() {Id = 3, Navn = "Hængekøjen", Beskrivelse = "Selvstændig virksomhed som hængekøjetester i egen have"}
                                };
        }
    }


    public class UddannelseRepository : ErfaringBaseRepository<Uddannelse>
    {
        public UddannelseRepository()
        {
            Entities = new List<Uddannelse>()
                            {
                                new Uddannelse() { Id = 1, Navn = "Gåserød lilleskole", Beskrivelse = "Bestod med udemærkelse"},
                                new Uddannelse() { Id = 2, Navn = "Andeby folkeskole"},
                                new Uddannelse() { Id = 3, Navn = "Andeby Dovneuniversitet", Beskrivelse = "5 års dovenskab og sløseri"}
                            };
        }
    }


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