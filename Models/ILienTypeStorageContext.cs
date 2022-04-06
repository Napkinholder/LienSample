
namespace LienSample.Models
{
    public interface ILienTypeStorageContext
    {
        public IDictionary<string, LienType> GetAll();
    }
}

