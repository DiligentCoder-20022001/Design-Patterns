using System;
public class Document
{
    
}
public interface IMachine // multi function printer
{
    void Print(Document d); 
    void Scan(Document d);
    void Fax(Document d);
}
public class MultiFunctionPrinter : IMachine // we implement each of the member functions
{
    public void Print(Document d)
    {
        //
    }
    public void Scan(Document d)
    {
        //
    }
    public void Fax(Document d)
    {
        //
    }
}
//old fashioned printers cant fax or scan -> the functions implemented are just a waste of time and spcae
public class OldFashionedPrinter : IMachine 
{
    public void Print(Document d)
    {
        //
    }
    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
    public void Fax(Document d)
    {
        throw new NotImplementedException();
    }
}

public class Test
{
	public static void Main()
	{
		// your code goes here
	}
}
