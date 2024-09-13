namespace APO_TEST.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public ProductModel(int Id, string name, string description, float price) {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

    }
}
