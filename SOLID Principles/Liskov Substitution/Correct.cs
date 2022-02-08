using System;
//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class Rectangle
{
    public virtual int Width { get; set; } 
    public virtual int Height { get; set; } 
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
    public override int Width // whenever the width from rectangle is now looked it directly comes over here
    {
        set 
        {
            //based on width change the height as it is a Square 
            base.Width = base.Height = value; 
        }
    }
    public override int Height 
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
	    Console.WriteLine("Area of rectangle is => " + Area(rc));//6
	    Square s1 = new Square();
	    s1.Width = 2; // here both the width and height are getting set
	    Console.WriteLine("Area of square is => " + Area(s1)); //4
	    Rectangle s2 = new Square();
	    s2.Width = 3; // since its overriden the height gets set in the square part 
	    Console.WriteLine("Area of a square is => " + Area(s2));//9
	    Rectangle r1 = new Rectangle(); // here the override doesnt come to use as both the types are matching
	    r1.Width = 5;
	    r1.Height = 4;
	    Console.WriteLine("Area of rectangle => " + Area(r1)); // 20
	}
}
