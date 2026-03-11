/*Challenge 1
bool paidFees = true;
bool hasIDcard = true;
bool hasDoneMatric = false;
bool isCitizen = false;

if ((paidFees && hasIDcard) || (hasDoneMatric || isCitizen))
{
    Console.WriteLine("Can take the final exam");
}
else
{
    Console.WriteLine("Cannot take the final exam");
}

Explanation: The paidfee and hasidcard is a true statement, has donematric or iscitizen combined together is a false statement.
So, combining the true or false statement, the answer is true. This means that the student must have paid the school fees and have 
IDcard or hasdonematric or is a citizen to be able to take the final exam. Since, the statement is true, the student can take the final exam.#2#

//Challenge 2
bool paidSfees = false;
bool hasidcard = true;
bool hasdoneregistration = true;
bool iscitizen = false;

if ((hasdoneregistration && paidSfees) || (iscitizen && hasidcard))
{
    Console.WriteLine("Can access the portal");
}
else
{
    Console.WriteLine("Cannot access the portal");
}*/

/*Explanation: hasdoneregistration and paidfees is a false statement because one of the statement is false, in "and" statement both must be true.
 Iscitizen is false and hasidcard is true which is still a false statement because in "and" statement both must be true. 
 Combining two false OR statement is false. This means, student cannot access the portal #2#
 */


//Challenge 3
/*int score = 45;*/
/*int score = 55;*/
/*int score = 65;*/
/*int score = 75;*/


/*
if (score >= 80)
{
    Console.WriteLine("A");
}    
else if (score >= 60)
{
    Console.WriteLine("B");
}
else if (score >= 50)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("Fail");
}

Explanation: Score 45 is below 50 which means it is fail, 
score 55 is above 50 which means it is Grade C, 
score 65 is above 60 which is Grade B and 
score 75 is above 60 but below 80 which is still Grade B.*/





/*Explanation: 

// Challenge 4
bool paidfees = true;
bool hasIDCard = true;
bool isStaff = false;
bool bookReserved = false;

if (paidfees && hasIDCard || isStaff && bookReserved)
{
    Console.WriteLine("Can borrow a book");
}
else
{
    Console.WriteLine("Cannot borrow a book");
}

/*Explanation: hasdoneregistration and paidfees is a false statement because one of the statement is false, in "and" statement both must be true.
 Iscitizen is false and hasidcard is true which is still a false statement because in "and" statement both must be true.
 Combining two false OR statement is false. This means, student cannot access the portal #1#


//Challenge 5
/*bool paidSchoolFees = true;
bool hasIDCard = true;
bool hasDMAtric = false;
bool hasDoneRegistration = false;
bool isCCitizen = false;

if (paidSchoolFees && hasIDCard && (hasDMAtric || hasDoneRegistration) || isCCitizen && hasIDCard)
{
    Console.WriteLine("Student verified");
}
else
{
    Console.WriteLine("Student not verified");#1#
}

/*Explanation: combining paidschoolfees and hasidcard is a true statement, hasdonematric or hasdoneregistration
 is a false statement, iscitizen and hasidcard is a false statement. The combination of true and false is false, 
 combining false or false is also a false statement. This means that the student is not verified #1#*/