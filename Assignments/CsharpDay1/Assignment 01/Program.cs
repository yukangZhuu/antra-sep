using Assignment_01;

// Playing with Console App

// Console.WriteLine("Hi, please type in your first name: ");
// string firstName = Console.ReadLine();
// Console.WriteLine("please type in your last name: ");
// string lastName = Console.ReadLine();
// Console.WriteLine($"Nice to meet you, {firstName} {lastName}.");


// Practice number sizes and ranges

// 1. Create a console application project named /02UnderstandingTypes/ that outputs the
//    number of bytes in memory that each of the following number types uses, and the
//    minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
//    ulong, float, double, and decimal
NumSizesAndRanges.PrintSizesAndRanges();



// 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
//    minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
//    type for every data conversion. Beware of overflows!
Console.Write("Enter number of centuries: ");
int centuries = int.Parse(Console.ReadLine());
CenturyConverter.ConvertCenturies(centuries);



// 1. FizzBuzz is a group word game for children to teach them about division. Players take turns
// to count incrementally, replacing any number divisible by three with the word /fizz/, any
//    number divisible by five with the word /buzz/, and any number divisible by both with /fizzbuzz/.
//    Create a console application in Chapter03 named Exercise03 that outputs a simulated FizzBuzz game counting up to 100
FizzBuzz.PlayGame(100);



// What will happen if this code executes?
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     WriteLine(i);
// }
// Create a console application and enter the preceding code. Run the console application and view the output. What happens?
// What code could you add (don’t change any of the preceding code) to warn us about the problem?

// i is a byte, which can only hold values from 0 to 255. When i reaches 255 and the loop increments it,
// i overflows and wraps back around to 0, thus never reaching 500 and causing the loop to continue indefinitely.
//The modified code:
int max = 500;
byte pre = 0;    //the previous value of i in the last iteration

for (byte i = 0; i < max; i++)
{
    if (i < pre)
    {
        Console.WriteLine("Warning: Byte variable 'i' overflows.");
        break; 
    }
    Console.WriteLine(i);
    pre = i;
}





// 2. Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
//     will print the following pattern: 
//     *
//    ***
//   *****
//  *******
// *********
PrintPyramid.PrintRow(10);



// 3. Write a program that generates a random number between 1 and 3 and asks the user to
//     guess what the number is. Tell the user if they guess low, high, or get the correct answer.
//     Also, tell the user if their answer is outside of the range of numbers that are valid guesses
//     (less than 1 or more than 3). You can convert the user's typed answer from a string to an int using this code:
//     int guessedNumber = int.Parse(Console.ReadLine());
//     Note that the above code will crash the program if the user doesn't type an integer value.
//     For this exercise, assume the user will only enter valid guesses
NumberGuessing.PlayGame();



// 4. Write a simple program that defines a variable representing a birth date and calculates
// how many days old the person with that birth date is currently.
//     For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
//     Note: once you figure out their age in days, you can calculate the days until the next
// anniversary using int daysToNextAnniversary = 10000 - (days % 10000); 
DaysOldCalculator.Calculate(1999, 3, 21);  //birth date: 1999-3-21



// 5. Write a program that greets the user using the appropriate greeting for the time of day.
//     Use only if , not else or switch , statements to do so. Be sure to include the following
// greetings:
// "Good Morning"
// "Good Afternoon"
// "Good Evening"
// "Good Night"
// It's up to you which times should serve as the starting and ending ranges for each of the
// greetings. If you need a refresher on how to get the current time, see DateTime
// Formatting. When testing your program, you'll probably want to use a DateTime variable
// you define, rather than the current time. Once you're confident the program works
//     correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
// assign DateTime.Now as its value, which is often a better approach).
UserGreeting.Greet();


// 6. Write a program that prints the result of counting up to 24 using four different increments.
//     First, count by 1s, then by 2s, by 3s, and finally by 4s.
//     Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
//     count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
//     loop control variable/ from the outer loop. This means the incrementing in the /
//     afterthought/ expression will be based on a variable.
CountTo24.Count();