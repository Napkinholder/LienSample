using LienSample.Models;

namespace LienSample.Mocks
{
    public class LienTypeStorageContext : ILienTypeStorageContext
    {
        private static Dictionary<string, LienType> _Storage;

        static LienTypeStorageContext()
        {
            var lienTypes = new LienType[]
            {
                new LienType {
                    Id = "V",
                    Name = "Voluntary"
                },
                new LienType {
                    Id = "N",
                    Name = "Non-Consensual"
                },
                new LienType {
                    Id = "S",
                    Name = "Statutory"
                },
                new LienType {
                    Id = "J",
                    Name = "Judicial"
                }
            };

            _Storage = new Dictionary<string, LienType>();
            foreach (var lienType in lienTypes) {
                _Storage.Add(lienType.Id, lienType);
            }

        }

        public IDictionary<string, LienType> GetAll()
        {
            return _Storage;
        }
    }
}
