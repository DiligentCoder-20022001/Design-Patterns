using System;
public class Document
{
    
}
//Note "//" means function is valid else we have written throw exception
//broken down into many interfaces
public interface IPrinter 
{
    void Print(Document d);
}
public interface IScanner 
{
    void Scan(Document d);
}
public interface IFaxMachine 
{
    void Fax(Document d);
}
public interface IMachine : IScanner, IPrinter, IFaxMachine
{
    
}
public class Photocopier : IPrinter, IScanner 
{
    public void Print(Document d)
    {
        //
    }
    public void Scan(Document d)
    {
        //
    }
}
public class MultiFunctionPrinter : IMachine
{
    void Print(Document d)
    {
        //
    }
    void Fax(Document d)
    {
        //
    }
    void Scan(Document d)
    {
        //
    }
}

public class Test
{
	public static void Main()
	{
		// your code goes here
	}
}
