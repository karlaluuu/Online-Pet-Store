using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreAPIClient
{
    public class PetStore
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string StoreAddress { get; set; }

        public override string ToString()
        {
            return $"{StoreId,-5}\n{StoreName,-10}\n{StoreDescription,-10}\n{StoreAddress,-10}\n\n";
    }
    }

}
