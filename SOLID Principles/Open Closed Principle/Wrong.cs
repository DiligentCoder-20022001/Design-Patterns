//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA

using System;
using System.Collections.Generic;
public enum Color
{
    Red, Green, Blue
}
public enum Size 
{
    Small, Medium, Large, Huge
}
public class Product
{
    public string Name; 
    public Color Color;
    public Size Size; 
    public Product(string name, Color color, Size size)
    {
        this.Name = name; 
        this.Color = color; 
        this.Size = size; 
    }
}
public class ProductFilter 
{
    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach(var p in products)
        {
            if(p.Size == size)
            {
                yield return p;
            }
        }
    }
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach(var p in products)
        {
            if(p.Color == color)
            {
                yield return p;
            }
        }
    }
    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    {
        foreach(var p in products)
        {
            if(p.Size == size && p.Color == color)
            {
                yield return p;
            }
        }
    }
}
public class Test
{
	public static void Main()
	{
	    var apple = new Product("Apple", Color.Green, Size.Small); 
	    var tree = new Product("Tree", Color.Green, Size.Huge);
	    var house = new Product("House", Color.Blue, Size.Large); 
	    Product[] products = {apple, tree, house}; 
	    var pf = new ProductFilter(); 
	    Console.WriteLine("Green Products are => "); 
	    foreach(var p in pf.FilterByColor(products, Color.Green))
	    {
	        Console.WriteLine(p.Name);
	    }
	}
}
