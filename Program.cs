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

using System.Diagnostics;

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

/*int score = 100;

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
}*/



//14th March 2026
// Operator = !

/*bool passedExam = true;
if (!passedExam)
{
    Console.WriteLine("You are passed the exam");
}
else
{
    Console.WriteLine("You passed the exam");
}*/


//Combining ranging values
/*int number = 15;
if (number is >= 10 && number <= 20)
{
    Console.WriteLine("number is within range");
}
else
{
    Console.WriteLine("number is not within range");
}*/


/*LOOPS: is a way to repeat a set of instructions multiple times until a certain condition is met.
 There are 3 types of loops
 - For loop
 - While loop
 - Do-while loop*/

//While loop repeats a block of code as long as condition is true, Example

//while (condition)
/*{
    run your code
}*/


//Compilation Error and Run-Time Error
/*int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++; //incrementing
}*/

// Do while: runs code first, check the conditions if true and then it repeat 

/*
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);*/

// For loop: is used when you know the number of times you want to loop.

/*
for (Initialization, Conditional, update)
{
    code to run
}    
*/

/*for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}   */ 


//Class assessment
/*int i = 99;

do
{
    Console.WriteLine(i);
    i++;
} while (i <= 107);*/

// Print even numbers from 1 to 20
/*for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/


//Array: is usd to store multiple variables of some data type in one variable

/*int num1 = 10;
int num2 = 20;
int num3 = 30;

int [] numbers = {10, 20, 30, 40, 50};

string student1 = "Lekan";
string student2 = "Maryam";
string student3 = "Jumah";

string[] students = {"Lekan", "Maryam", "Muheeb", "Fatimah", "Pedro", "Baraka"};*/

//Console.WriteLine($"Fatimah name to be printed \n..Printout result = {student[3]}")// fatimah

// indexing starts from 0
// Length starts from 1



//Console.WriteLine(students.Length); this prints the length of the students

/*for (int i = 0; i < students.length; i++)
 {
 Console.WriteLine(students[i]);
 }
 */


//Formatting to have students number
//Console.WriteLine(students.Length); this prints the lenght of the students 


/*for (int i = 0; i < students.Length; i++)
{
 Console.WriteLine($"Student{i + 1} : {students[i]}");
}*/

// we acheived
/*Student1 : lekan
Student2 : mariam
Student3 : muheeb
Student4 : fatimah
Student5 : Pedro
Student6 : barakah*/




//int[] numbers = { 10, 20, 30 }; // array of numbers 

/*
for (int i = 0; i < numbers.Length; i++)
{
 Console.WriteLine(numbers[i]);
}
*/

// 10
// 20
// 30
// 40


// Using loop to Add numbers together

/*int[] numbers = { 10, 20, 30, 40 }; // array of numbers

int sum = 0; // base number we want to use to perform add operation

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
    sum += numbers[i]
    // sum = 0 + (numbers[0]) 10 = 10
    // sum = 10 + (numbers[1]) 20 = 30
    // sum = 30 + (number[2]) 30 = 60
    // sum = 60 + (number[3]) 40 = 100
    // sum = 100

}

Console.WriteLine($"Sum of all the numbers = {sum}");*/

// Using Loop to multiply together
/*int[] numb = { 2, 3, 4, 5, 6 };

int mult = 1;

for (int i = 0; i < numb.Length; i++)
{
  mult = mult * numb[i];
}
Console.WriteLine($"Multiplication of all the numbers = {mult}");*/


// Lets Build Multiplication table 

int multiplicationTable = 6;

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{multiplicationTable} X {i} = {multiplicationTable * i}");
}

// 2 X 1 = 2
// 2 X 2 = 4