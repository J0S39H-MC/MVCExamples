using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
  public class ShoppingCart
  {
    private LinqValueCalculator calc;

    public IEnumerable<Product> Products { get; set; }

    public ShoppingCart(LinqValueCalculator calcParam)
    {
      calc = calcParam;
    }

    public decimal CalculateProductTotal()
    {
      return calc.ValueProducts(Products);
    }
  }
}