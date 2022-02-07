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
//implementating open closed principle 
public interface ISpecification<T>
{
    //implements the specification pattern -> color, size <T>->indicates generel type
    bool isSatisfied(T t); // checks whether the particular item statisfies the criteria 
}
//filtering mechanism which functions on any type 
public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec); // we feed it a bunch of products and the specification and then filter
}
//filtering by color 
public class ColorSpecification : ISpecification<Product>
{
    private Color color;
    public ColorSpecification(Color color)
    {
        this.color = color;
    }
    public bool isSatisfied(Product t){
        return t.Color == color;
    }
}
public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach(var i in items)
        {
            if(spec.isSatisfied(i))
            {
                yield return i;
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
	    var bf = new BetterFilter(); 
	    Console.WriteLine("Green products =>"); 
	    foreach(var p in bf.Filter(products, new ColorSpecification(Color.Green)))
	    {
	        Console.WriteLine(p.Name);
	    }
	}
}
