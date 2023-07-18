﻿using System.ComponentModel.DataAnnotations;

namespace web_app.Models;

public class Stock
{
    [Key]
    public int StockID { get; set; }

    [Required]
    [StringLength(50)]
    public string Symbol { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }
    [Required]
    public decimal PriceLow { get; set; }
    [Required]
    public decimal PriceHigh { get; set; }
    public List<Transaction> Transactions { get; set; } = new ();

    public Stock()
    {
        StockID = 0;
        Symbol = "";
        Name = "";
        Price = 0;
        PriceHigh = 0;
        PriceLow = 0;
    }
    
    public Stock(int stockId, string symbol, string name, decimal price, decimal priceLow, decimal priceHigh)
    {
        StockID = stockId;
        Symbol = symbol;
        Name = name;
        Price = price;
        PriceLow = priceLow;
        PriceHigh = priceHigh;
    }
}