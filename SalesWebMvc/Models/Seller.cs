using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime BithDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime bithDate, double baseSalary, Department department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            BithDate = bithDate;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddSales(SalesRecord sr)
        {

            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {

            Sales.Remove(sr);
        }


        public double TotalSales ( DateTime initial, DateTime final)
        {

            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
