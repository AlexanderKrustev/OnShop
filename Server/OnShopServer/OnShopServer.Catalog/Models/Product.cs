namespace OnShopServer.Catalog.Models
{
    using System.Collections.Generic;

    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal BasePrice { get; set; }

        public decimal CurrentPrice { get; set;  }

        public Category MainCategory { get; set; }

        protected IEnumerable<Category> SubCategories { get; set; } = new List<Category>();
    }
}
