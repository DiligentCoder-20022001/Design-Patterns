using System;
public class SalaryCalculator
{
    public float CalculateSalary(int hoursWorked, float hourlyRate)
    {
        return hoursWorked*hourlyRate;
    }
}
public class EmployeeDetails 
{
    public int HoursWorked { get; set; } 
    public int HourlyRate { get; set; }
    public float GetSalary()
    {
        var SalaryCalculator = new SalaryCalculator();
        return SalaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
    }
}
public class Test
{
	public static void Main()
	{
		// your code goes here
	}
}
/*These classes do not follow the “Dependency Inversion Principle” as the higher-level class EmployeeDetails is directly depending upon the lower level SalaryCalculator class.*/
