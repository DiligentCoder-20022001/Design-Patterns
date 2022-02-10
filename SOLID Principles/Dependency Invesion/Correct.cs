using System;
/*In the above code, we see that we have created an interface ISalaryCalculator and then we have a class called SalaryCalculatorModified that implements this interface. Finally, in the higher-level class EmployeeDetailsModified, we only depend upon the ISalaryCalculator interface and not the concrete class. Hence, when we create the EmployeeDetailsModified class, we specify the abstraction implementation to use. In addition to this, the details of the CalculateSalary function are hidden from the EmployeeDetailsModified class and any changes to this function will not affect the interface being used. Hence, we can see that in this new design the higher-level class does not depend upon the lower level class but on an abstraction and the abstraction does not depend upon the details. */
public interface ISalaryCalculator
{
    float CalculateSalary(int hoursWorked, float hourlyRate); 
}
//low level class
public class SalaryCalculatorModified : ISalaryCalculator 
{
    public float CalculateSalary(int hoursWorked, float hourlyRate)
    {
        return hourlyRate*hoursWorked;
    }
}//high level class
public class EmployeeDetailsModified 
{
    private readonly ISalaryCalculator _salaryCalculator; 
    public int HoursWorked { get; set; }
    public int HourlyRate { get; set; } 
    public EmployeeDetailsModified(ISalaryCalculator sc)
    {
        _salaryCalculator = sc; 
    }
    public float GetSalary()
    {
        return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
    }
}
public class Test
{
	public static void Main()
	{
		// your code goes here
	}
}
