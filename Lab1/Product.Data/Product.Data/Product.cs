using System;

namespace Product.Data
{
    public class Product
    {
        public Product(Guid id, string name, string description, DateTime startDate, DateTime endDate, double price, double vat)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            VAT = vat;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }

        public bool IsValid
        {
            get
            {
                if (StartDate < DateTime.Now && EndDate > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public double ComputeVAT
        {
            get
            {
                return Price * VAT / 100;
            }
        }
    }
}