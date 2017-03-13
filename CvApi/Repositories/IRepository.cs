using System.Threading.Tasks;
using CvApi.Models;

namespace CvApi.Repositories
{
    public interface IRepository
    {
        Task<Cv> Get(int id);
    }
}