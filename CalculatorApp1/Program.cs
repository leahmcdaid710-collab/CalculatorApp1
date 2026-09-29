void CalculatorApp1()
{
	try
	{
		Console.WriteLine("enter the first number");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("enter the second number");
		int secondNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("enter the operation (+, -, *, /)");
		char operation = Convert.ToChar(Console.ReadLine());
		int result = 0;

        switch (operation)				
		{
			case '+':
            result = firstNumber + secondNumber;
            break;
			case '-':
			result = firstNumber - secondNumber;
				break;
				case '*':
				result = firstNumber * secondNumber;
				break ;
				case '/':
				result = firstNumber / secondNumber;
				break;

        }

		Console.WriteLine($"result: {result}");
    }
	catch (Exception ex)
	{
		Console.WriteLine($"Error: {ex.Message}. Please enter a valid operation.");
        
	}
}
CalculatorApp1();