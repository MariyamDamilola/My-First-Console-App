//Console.WriteLine("Hello world");
//Console.WriteLine("My name is Maryam");

//Variable Declaration(int , double , string , bool)

//int age = 30;

//string name = "Maryam";

//double height = 20.7;

//bool isMarried = false;

////////////////////////////////////

//Console.WriteLine(name + " " + height); // string concatenation

//Console.WriteLine($"{name} {height}");

//FOR STRING INTERCOLATION
//Console.WriteLine($"My name is {name}, i am {age} years old. My height is height. Are you a married: {isMarried}");

//Console.WriteLine("my name is" + name + ", i am" + age + " years old. My height is" + height + "are you married: + isMarried");


//MARCH 7TH 2026
//decimal money = 1000746.6083683m;

//float temperature = 30.5f;

//char letter = 'f';



//int: memory = 4byte, whole number e. g 10, 20, 30
//float: memory = 4byte, decimal number (less precision) e. g 10.5f, 20.5f
//double: memory = 8byte, decimal numbers e. g 10.6786, 67.967
//long: memory = 8byte, very large numbers e. g 900000000000000000000000
//decimal: memory = 16byte, very precise values(money), e. g bank acct balance.


// max : 2,147484647
// min : -2147484647

//Subject: operators

// We have four operators: =, -, *, /

//int a = 45;
//int b = 40;
//int addedResult = a + b;
//int subResult = a - b;
//int multiplyResult = a * b;
//double divideResult = (double)a / b;

//Console.WriteLine($"Adding a and b values = {addedResult}");
//Console.WriteLine($"Subtracting a and b values = {subResult}");
//Console.WriteLine($"Multiplying a and b values = {multiplyResult}");
//Console.WriteLine($"Dividing a and b values = {divideResult}");


//int pop1 = 200000;
//long pop2 = 9000000000;
//long popresult = pop1 + pop2;

//Console.WriteLine($"Population total = {popresult}");

//Note there is no precision loss

//int jumahbalance = 100;
//double sweetprice = 5.75;

//double jumahamountleft = jumahbalance + sweetprice;
//Console.WriteLine($"Jumah Total = {jumahbalanceleft}"); // no precision loss

//float value1 = 5.234534635634f;
//decimal value2 = 2.5m;

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
//int ab = 10;
//int bc = 5;

//int remainder = ab % bc;
//Console.WriteLine($"Remainder values = {remainder}");

//int balance = 5000;
//int amounttransferred = 3000

//int newbalance = balance - amounttransferred; // conventional way
//balance -= amounttransferred;
//Console.WriteLine($"new balance = {newbalance}");

/*int cd = 2;
int de = 5;*/

//int jk = cd * de; // conventional way

//cd *= de; // preferred way



//march 8 2026

//Comparison Operators
// ==, equal to
// !=, not equal to
// >, greater than
// <, less than
// >=, greater than or equal to
// <=, less than or equal to

//Examples
int a = 10;
int b = 5;

//Console.WriteLine(a > b); //true
//Console.WriteLine(a == b); // false
//Console.WriteLine(a != b); //true

// we make us of "if and if-else" statement for conditional operators


//logical operators
// &&, means "AND", bind true and true values
// ||, means "OR", only one has to be true
// !, means "Not"

//Examples of logical and comparison operators

int score = 100;

if (score >= 70)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade D");
}    

//Logical operators
int score = 30;

if (score >= 50 && score <= 100)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Failed");
}

bool paidfees = true;
bool hasIDcard = true;
bool hasdonematric = false;

if (paidfees && hasIDcard && hasdonematric)
{
    Console.WriteLine("You can enter the exam hall");
}
else
{
    Console.WriteLine("You cannot enter");
}


//Using//
bool isStudent = false;
bool isSeniorCitizen = false;

if (isStudent || isSeniorCitizen)
{
    Console.WriteLine("You are qualitied for discount");
}
else
{
    Console.WriteLine("You are not qualitied for discount");
}

// combinig the && and ||
bool paidfees = true;
bool hasIDcard = true;
bool hasdonematric = false;
bool hasdoneRegistration = false;
bool isCitizen = false;

//1
if ((paidfees && hasIDcard || hasdonematric)
{
    Console.WriteLine("You can enter the exam hall");
} 
else
{
     Console.WriteLine("You cannot enter the exam hall");
}

//2
if ((hasdoneRegistration && paidfees) || isCitizen)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Denied");
}

//3
if (paidfees && (hasdonematric || hasdoneRegistration))
{
    Console.WriteLine("Student is fully verified");
}
else
{
    Console.WriteLine("Student is not verified");
}

//4
if ((paidfees && hasIDcard) && (hasdonematric || hasdoneRegistration || isCitizen))
{
    Console.WriteLine("Student cleared");
}
else
{
    Console.WriteLine("Student not cleared");
}

//5
if ((paidfees && hasIDcard) && (hasdonematric || hasdoneRegistration) || (isCitizen && hasIDcard))
{
    Console.WriteLine("Student can write the final exam");
}
else
{
    Console.WriteLine("Student cannot write the final exam");
}

//6
if (hasdonematric || paidfees && hasIDcard)
{
    Console.WriteLine("Student verified");
}
else
{
    Console.WriteLine("Student not verified");
}

//7
if (paidfees && hasIDcard && hasdonematric && hasdoneRegistration)
{
    Console.WriteLine("Student fully cleared");
}
else
{
    Console.WriteLine("Student not fully cleared");
}

//8
if (paidfees || hasIDcard || hasdonematric || isCitizen)
{
    Console.WriteLine("Student allowed");
}
else
{
    Console.WriteLine("Student not allowed");
}

//9
if (paidfees || hasIDcard && hasdonematric || hasdoneRegistration)
{
    Console.WriteLine("Approved");
}
else
{
    Console.WriteLine("Rejected");
}

//10
if (paidfees || hasIDcard && hasdonematric || hasdoneRegistration && isCitizen)
{
    Console.WriteLine("Allowed");
}
else
{
    Console.WriteLine("Not allowed");
}