using System.Collections.Generic;
using System.Threading.Tasks;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class CvRepository : IRepository
    {
        private List<Firma> _firmaer = new List<Firma>() { new Firma() { Id = 1, Navn = "LEGO" }, new Firma() { Id = 2, Navn = "Maersk" } };
        private Cv _cv = new Cv()
        {
            Overskrift = "*** Curriculum Vitae ***",
            Navn = "Anders And",
            Alder = 82,
            Resume = "Har mange års erfaring med dovneri i hængekøje, samt pudsning af mønter. Kan til tider blive meget ophidset og har det med at komme galt afsted",
        };

        //public Task<Firma> Get(int id)
        //{
        //    return Task.FromResult(_firmaer.FirstOrDefault(dr => dr.Id == id));
        //}

        public Task<Cv> Get(int id)
        {
            return Task.FromResult(_cv);
        }
    }
}