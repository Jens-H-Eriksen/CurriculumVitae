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
}