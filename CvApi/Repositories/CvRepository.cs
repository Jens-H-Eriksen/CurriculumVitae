using System.Collections.Generic;
using System.Threading.Tasks;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class CvRepository : IRepository
    {
        private List<Firma> _firmaer = new List<Firma>() { new Firma() { Id = 1, Navn = "LEGO" }, new Firma() { Id = 2, Navn = "Maersk" } };
        private CvAfsnit _cvAfsnit = new CvAfsnit() {Overskrift = "Alle firmaer"};

        //public Task<Firma> Get(int id)
        //{
        //    return Task.FromResult(_firmaer.FirstOrDefault(dr => dr.Id == id));
        //}

        public Task<CvAfsnit> Get(int id)
        {
            return Task.FromResult(_cvAfsnit);
        }
    }
}