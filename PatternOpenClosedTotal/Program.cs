using PatternOpenClosedTotal.Class;
using PatternOpenClosedTotal.Fabric;
using PatternOpenClosedTotal.Profiles;

//Создание аккаунтов
string accountType1 = "Обычный";
string accountType2 = "Зарплатный";
Account account1 = new Account(500);
Account account2 = new Account(1000);

// Использование фабрики для создания нужных калькуляторов
ICalculatorFactory calculatorFactory = new CalculatorFactory();
ICalculate calculator1 = calculatorFactory.CreateCalculator(accountType1);
ICalculate calculator2 = calculatorFactory.CreateCalculator(accountType2);

calculator1.Calculate(account1);
calculator2.Calculate(account2);

Console.WriteLine($"Account 1 Interest: {account1.Interest}");
Console.WriteLine($"Account 2 Interest: {account2.Interest}");


