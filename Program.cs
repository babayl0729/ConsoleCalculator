Console.WriteLine("Enter number to select calculation:");
Console.WriteLine("Enter 1 for Addition.");
Console.WriteLine("Enter 2 for Subtraction.");
Console.WriteLine("Enter 3 for Multiplication.");
Console.WriteLine("Enter 4 for Division.");

int cal;
cal = Convert.ToInt32(Console.ReadLine());
if(cal == 1) {
    Console.WriteLine($"You entered {cal} = Addition");
} 
else if(cal == 2) {
    Console.WriteLine($"You entered {cal} = Subtraction");
}
else if(cal == 3) {
    Console.WriteLine($"You entered {cal} = Multiplication");
}
else if(cal == 4) {
    Console.WriteLine($"You entered {cal} = Division");
} else {
    Console.WriteLine($"You entered {cal} = Invalid entry.");
    return;
}

Console.WriteLine("Enter first number");
double num1;
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"You entered {num1}");

Console.WriteLine("Enter second number");
double num2;
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"You entered {num2}");

if(cal == 1) {
    Console.WriteLine($"{num1} + {num2}");
    Console.WriteLine($"Sum: {num1 + num2}");
}
else if(cal == 2) {
    Console.WriteLine($"{num1} - {num2}");
    Console.WriteLine($"Difference: {num1 - num2}");
} 
else if(cal == 3) {
    Console.WriteLine($"{num1} * {num2}");
    Console.WriteLine($"Product: {num1 * num2}");
}
else if(cal == 4) {
    Console.WriteLine($"{num1} / {num2}");
    Console.WriteLine($"Dividend: {num1 / num2}");
} else {
    Console.WriteLine("Enter valid num");
}