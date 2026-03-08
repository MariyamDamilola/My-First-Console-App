// Task 1 - Arithmetic Operators
int a = 60;
int b = 25;
int addvalue = a + b;
int subvalue = a - b;
int mulvalue = a * b;
int divvalue = a / b;
int modvalue = a % b;

Console.WriteLine($"The sum of the values = {addvalue}");
Console.WriteLine($"The subtraction of the values = {subvalue}");
Console.WriteLine($"The multiplication of the values = {mulvalue}");
Console.WriteLine($"The division of the values = {divvalue}");     
Console.WriteLine($" The remainder of the values = {modvalue}");

//Task 2 - Interger vs Double Division
int c = 10;
int d = 4;

int e = c / d;
double f = c / d;

Console.WriteLine($"The result of division {e}");
Console.WriteLine($"The result of division {f}");

//Task 3 - Large Numbers
long population = 1000000;
int increase = 34546;
long newpopulation = population + (long)increase;

Console.WriteLine($"New population is {newpopulation}");


//Task 4 - Shop calculator
double price = 1500.75;
int quantity = 3;
double totalcost = price * (double)quantity;

Console.WriteLine($"The total cost is {totalcost}");

// Task 5 
int number1 = 20;
int number2 = 30;
int number3 = 40;

double average = (number1 + number2 + number3) / 3;
Console.WriteLine($"The average is {average}");