﻿namespace WebCoreMvcFromScratch.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Unit { get; internal set; }
    }
}