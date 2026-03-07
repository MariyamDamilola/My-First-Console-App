//Console.WriteLine("Hello world");
//Console.WriteLine("My name is Maryam");

//Variable Declaration(int , double , string , bool)

int age = 30;

string name = "Maryam";

double height = 20.7;

bool isMarried = false;

////////////////////////////////////

//Console.WriteLine(name + " " + height); // string concatenation

//Console.WriteLine($"{name} {height}");

//FOR STRING INTERCOLATION
//Console.WriteLine($"My name is {name}, i am {age} years old. My height is height. Are you a married: {isMarried}");

//Console.WriteLine("my name is" + name + ", i am" + age + " years old. My height is" + height + "are you married: + isMarried");


//MARCH 7TH 2026
decimal money = 1000746.6083683m;

float temperature = 30.5f;
gg
char letter = 'f';



//int: memory = 4byte, whole number e. g 10, 20, 30
//float: memory = 4byte, decimal number (less precision) e. g 10.5f, 20.5f
//double: memory = 8byte, decimal numbers e. g 10.6786, 67.967
//long: memory = 8byte, very large numbers e. g 900000000000000000000000
//decimal: memory = 16byte, very precise values(money), e. g bank acct balance.

g
// max : 2,147484647
// min : -2147484647

//Subject: operators

// We have four operators: =, -, *, /

int a = 45;
int b = 40;
int addedResult = a + b;
int subResult = a - b;
int multiplyResult = a * b;
double divideResult = (double)a / b;

//Console.WriteLine($"Adding a and b values = {addedResult}");
//Console.WriteLine($"Subtracting a and b values = {subResult}");
//Console.WriteLine($"Multiplying a and b values = {multiplyResult}");
//Console.WriteLine($"Dividing a and b values = {divideResult}");


int pop1 = 200000;
long pop2 = 9000000000;
long popresult = pop1 + pop2;

//Console.WriteLine($"Population total = {popresult}");

//Note there is no precision loss

//int jumahbalance = 100;
//double sweetprice = 5.75;

//double jumahamountleft = jumahbalance + sweetprice;
//Console.WriteLine($"Jumah Total = {jumahbalanceleft}"); // no precision loss

float value1 = 5.234534635634f;
decimal value2 = 2.5m;

//decimal valueResult = (decimal)value1 + value2; //precision loss
//float valueResult = value1 + (float)value2; //no precision loss


//Easy Rules
//int + long = safe
// int + double = safe
//float + double = some precision loss
//double + decimal = conversion need for any variable type we want
//float + decimal = conversion need for any variable type we want
//decimal = best for money


//Example
int ab = 10;
int bc = 5;

int remainder = ab % bc;
Console.WriteLine($" ");