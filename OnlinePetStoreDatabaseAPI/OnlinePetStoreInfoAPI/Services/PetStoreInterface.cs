using OnlinePetStoreInfoAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePetStoreInfoAPI.Services
{
    public interface PetStoreInterface
    {
        Task<IEnumerable<PetStoreModel>> GetPetStore();
        Task<PetStoreModel> GetStoreById(int storeId);

        Task<bool> StoreExist(int storeId);
        Task AddStore(PetStoreModel petStore);
        void DeleteStore(PetStoreModel petStore);
        Task<bool> Save();
    }
}
