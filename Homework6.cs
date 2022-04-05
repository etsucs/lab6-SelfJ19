/*Programmer's Name: Jason Self
Course: CSCI 1250 Section Number: 001
Creation Date: 03/23/2022 Date of Last Modification: 03/23/2022
Purpose - Lab 6 Homework6*/

//Calls the ShowCharacter method
Console.WriteLine(ShowCharacter("Jason", 3));

//Asks user for input and stores it for the CalculateRetail method
Console.WriteLine("Please enter the item's wholesale cost: ");
double wholesale = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the markup percentage: ");
double percent = double.Parse(Console.ReadLine());
//Calls the CalculateRetail method
Console.WriteLine($"${wholesale} marked up {percent}% is ${CalculateRetail(wholesale, percent)}");

//Calls Celsius method inside a for loop  
for(int i = 80; i <= 100; i++)
{
    //Calls the Celsius method
    Console.WriteLine($"{i} degrees Fahrenheit is {Celsius(i)} degrees Celsius.");
}

//Asks user for input for the IsPrime method and stores it
System.Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool isAPrimeNumber = IsPrime(num);

if(isAPrimeNumber == true)
{
    System.Console.WriteLine($"{num} is a prime number.");
}
else
{
    System.Console.WriteLine($"{num} is NOT a prime number.");
}

//Calls the IsPrime method
for(int i = 1; i <= 20; i++)
{
    Console.WriteLine($"{i}:\t\t{IsPrime(i)}");
}

//ShowCharacter method
static char ShowCharacter(string str, int num)
{
    char charAt = str[num-1];
    return charAt;
}

//CalculateRetail method
static double CalculateRetail(double wholesale, double percent)
{
    double retail = (wholesale + (wholesale * (percent/100)));
    return retail;
}

//Celsius method
static double Celsius(double F)
{
    double C = Math.Round((5.0/9.0)*(F-32),2);
    return C;
}

//IsPrime method
static bool IsPrime(int num)
{
    if(num<=1)
    {
        return false;
    }
    if(num==2)
    {
        return true;
    }
    if(num%2==0)
    {
        return false;
    }
    for(int i =3; i<=Math.Floor(Math.Sqrt(num)) ; i+=2)
    {
        if(num%i==0)
        {
            return false;
        }
    }
    return true;
}