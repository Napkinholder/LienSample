using System.Collections.Generic;
using LienSample.Models;

namespace LienSample.Mocks
{
    public class LienStorageContext : ILienStorageContext
    {
        private static Dictionary<int, Lien> _Storage;

        static LienStorageContext()
        {
            var liens = new Lien[]
            {
                new Lien {
                    Company = "American Automotive",
                    CreatedDate = new DateTime(2022,1,21),
                    Amount = 7500,
                    LienType = "V"
                },
                new Lien {
                    Company = "Epic Electric",
                    CreatedDate = new DateTime(2022,1,22),
                    Amount = 11200,
                    LienType = "V"
                },
                new Lien {
                    Company = "Bottomline Bank",
                    CreatedDate = new DateTime(2022,1,22),
                    Amount = 500,
                    LienType = "J"
                },
                new Lien {
                    Company = "Cosmic Computers",
                    CreatedDate = new DateTime(2022,1,22),
                    Amount = 37500,
                    LienType = "S"
                },
                new Lien {
                    Company = "Leading Laboratories",
                    CreatedDate = new DateTime(2022,1,22),
                    Amount = 5500,
                    LienType = "V"
                }
            };

            _Storage = new Dictionary<int, Lien>();
            for (int i = 0; i < liens.Length; i++) {
                liens[i].Id = i + 1;
                _Storage.Add(i + 1, liens[i]);
            }
        }

        public LienStorageContext()
        {
        }

        public Lien Get(int id)
        {
            return _Storage[id];
        }

        public Lien Save(Lien model)
        {
            if (_Storage.ContainsKey(model.Id)) {
                _Storage[model.Id] = model;
            }
            else {
                model.Id = _Storage.Count + 1;
                _Storage.Add(model.Id, model);
            }
            return model;
        }

        public IEnumerable<Lien> Search()
        {
            return _Storage.Values;
        }
    }
}
