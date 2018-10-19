using System;

namespace ClassLibrary1
{
    public class Product
    {
        private string _productName;
        private string _description;

        public Product(Guid id, string productName, string description, DateTime startDate, DateTime endDate, double price)
        {
            Id = id;
            ProductName = productName;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        public Guid Id { get; set; }

        public string ProductName {
            get {
                return _productName;
            }

            private set
            {
                if (value.Length < 50)
                {
                    _productName = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            private set
            {
                if (value.Length < 200)
                {
                    _description = value;
                }
            }
        }

        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public double Price { get; set; }

    }
}
