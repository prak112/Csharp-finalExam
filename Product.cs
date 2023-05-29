namespace CourseExam
{
    public class Product
    {
        // Property
        private Random random = new Random();
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Product(string aName)
        {
            Id = random.Next(1000, 100000);
            Name = aName;
            Price = random.Next(10, 100) / 10;
        }

        // Method
        public decimal GetDiscountPrice(decimal price)
        {
            decimal discount = 0.2m;
            return (price - ( discount * price ) );
        }

    }

}