namespace Task3.Models
{
    public class ProductCategory
    {
        public string? ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public int LastUserId { get; set; }
        public DateTime LastDateUpdated { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }
    }
}
