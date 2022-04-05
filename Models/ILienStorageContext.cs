
namespace LienSample.Models
{
    public interface ILienStorageContext
    {
        public IEnumerable<Lien> Search();
        public Lien Get(int id);
        public Lien Save(Lien model);
    }
}

