namespace OnShopServer.Catalog.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public bool IsRootCategory { get; set; }

        public int ParentCategoryId  { get; set; }

        public IEnumerable<Product> Products { get; set; }

    }
}
