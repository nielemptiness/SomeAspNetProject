using System;
using MongoDB.Bson.Serialization.Attributes;
using Store.Contracts.Interfaces;

namespace Store.Contracts.Models
{
    public class Record : IEntity, IAuditable, ISellable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Seller { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        public DateTime? SoldDate { get; set; }
    }
}