using System;
//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class Rectangle
{
    public int Width { get; set; } 
    public int Height { get; set; } 
    public Rectangle()
    {
        Height = 0; 
        Width = 0;
    }
    public Rectangle(int width, int height)
    {
        Width = width; 
        Height = height; 
    }
}
public class Square : Rectangle 
{
    public new int Width
    {
        set 
        {
            //based on width change the height as it is a Square 
            base.Width = base.Height = value; 
        }
    }
    public new int Height 
    {
        set 
        {
            base.Width = base.Height = value;
        }
    }
}
public class Test
{
    public static int Area(Rectangle rc)
    {
        return rc.Width*rc.Height; 
    }
	public static void Main()
	{
	    Rectangle rc = new Rectangle(2, 3);
	    Console.WriteLine("Area of rectangle is => " + Area(rc));
	    Square s1 = new Square();
	    s1.Width = 2; // here both the width and height are getting set
	    Console.WriteLine("Area of square is => " + Area(s1)); // there is no issue over here because square is a child of rectangle class -> gives output 4
	    Rectangle s2 = new Square();
	    s2.Width = 3; // since its a rectangle only the width is getting set and not the height -> tihs can be prevent by use of constructors in the square class or by using virtual functions -> see the correct file for more understanding -> gives output 0
	    Console.WriteLine("Area of a square is => " + Area(s2));
	}
}
