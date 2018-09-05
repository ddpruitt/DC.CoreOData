using System.Threading.Tasks;

namespace DC.Data
{
    public interface IUnitOfWork
    {
        void SaveChanges();

        Task SaveChangesAsync();

    }
}