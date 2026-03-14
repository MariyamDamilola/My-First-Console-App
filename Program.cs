//TASK 1

int [] scores ={ 45, 70, 55, 30, 90, 60 };

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"{i}: {scores[i]}");
}

//2.
//Highest
int highestScore = scores[0];
int lowestScore = scores[0];
int Sum = 0;

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] > highestScore)
    {
        highestScore = scores[i];
    }
}
Console.WriteLine($"Highest score: {highestScore}");


//Lowest
for (int i = 0; i < scores.Length; i++)
{    
    if (scores[i] < lowestScore)
    {
        lowestScore = scores[i];
    }
}    
Console.WriteLine($"lowest score: {lowestScore}");


//Average
for (int i = 0; i < scores.Length; i++)
{
    Sum += scores[i];
}
double Average = (double)Sum / scores.Length;
Console.WriteLine($"Average Score: {Average}");





//TASK 2
int [] temperature = { 25, 32, 28, 35, 30, 29, 40 };

for (int i = 0; i < temperature.Length; i++)
{
    Console.WriteLine($"{i}: {temperature[i]}");
}


//2b
for (int i = 0; i < temperature.Length; i++)
{
    if (temperature[i] > 30)
    {
        Console.WriteLine($"Temperature above threshold: {temperature[i]}");
    }
}    

//2c
for (int i = temperature.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{i}: {temperature[i]}");
}

//2d
int tempSum = 0;
for (int i = 0; i < temperature.Length; i++)
{
    tempSum += temperature[i];
}
int Avetemp = tempSum / temperature.Length;
Console.WriteLine($"Average Score: {Avetemp}");