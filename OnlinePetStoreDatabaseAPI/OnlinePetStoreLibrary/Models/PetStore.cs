using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePetStoreLibrary.Models
{
    public partial class PetStore
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string StoreAddress { get; set; }
    }
}
