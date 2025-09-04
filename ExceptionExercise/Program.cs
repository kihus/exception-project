try
{
	var num1 = int.Parse(Console.ReadLine());
	var num2 = int.Parse(Console.ReadLine());

	var div = num1 / num2;

	Console.WriteLine(div);
}
catch(DivideByZeroException)
{
	Console.WriteLine("Division by zero is not allowed");
}
catch(FormatException e)
{
	Console.WriteLine("Format error! " + e.Message);
}

