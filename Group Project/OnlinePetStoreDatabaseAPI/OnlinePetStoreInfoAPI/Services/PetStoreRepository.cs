using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlinePetStoreInfoAPI.Models;

namespace OnlinePetStoreInfoAPI.Services
{
    public class PetStoreRepository : PetStoreInterface
    {
        private PetStoreDBContext petStoreContext;
        public PetStoreRepository(PetStoreDBContext context)
        {
            petStoreContext = context;
        }
        public async Task<IEnumerable<PetStoreModel>> GetPetStore()
        {
            var results = petStoreContext.Stores.OrderBy(c => c.StoreName);
            return await results.ToListAsync();
        }
        public async Task<PetStoreModel> GetStoreById(int storeId)
        {
            IQueryable<PetStoreModel> results;
            results = petStoreContext.Stores.Where(c => c.StoreId == storeId);
            return await results.FirstOrDefaultAsync();
        }
        public async Task<bool> StoreExist(int storeId)
        {
            return await petStoreContext.Stores.AnyAsync<PetStoreModel>(c => c.StoreId == storeId);
        }
        public async Task AddStore(PetStoreModel petStore)
        {
            petStoreContext.Stores.Add(petStore);
            await petStoreContext.SaveChangesAsync();
        }
        public void DeleteStore(PetStoreModel petStore)
        {
            petStoreContext.Stores.Remove(petStore);
        }
        public async Task<bool> Save()
        {
            return (await petStoreContext.SaveChangesAsync()) > 0;
        }
    }
}
