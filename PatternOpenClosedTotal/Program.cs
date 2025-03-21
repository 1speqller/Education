using PatternOpenClosedTotal.Class;
using PatternOpenClosedTotal.Profiles;

Account account1 = new Account("Обычный", 500);
Account account2 = new Account("Зарплатный", 1000);

CalculatorSalary calculatorSalary = new CalculatorSalary();
CalculatorDefault calculatorDefault = new CalculatorDefault();

calculatorDefault.Calculate(account1);
calculatorSalary.Calculate(account2);

Console.WriteLine($"{account1.Interest}, {account2.Interest}");