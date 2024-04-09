using Assignment_02;

// Practice Arrays

// 1. Copying an Array
// Write code to create a copy of an array. First, start by creating an initial array. (You can use
// whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
// assign it a new array with 10 items in it. Use the things we’ve discussed to put some values in the array.
// Now create a second array variable. Give it a new array with the same length as the first.
// Instead of using a number for this length, use the Lengthproperty to get the size of the original array.
// Use a loop to read values from the original array and place them in the new array. Also
// print out the contents of both arrays, to be sure everything copied correctly.
int[] array1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] array2 = new int[10];

for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}

foreach (int a in array2)
{
    Console.WriteLine(a);
}



// 2. Write a simple program that lets the user manage a list of elements. It can be a grocery list,
// "to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
//     implement an infinite loop. Each time through the loop, ask the user to perform an
//     operation, and then show the current contents of their list. The operations available should
// be Add, Remove, and Clear. The syntax should be as follows:
// + some item
//     - some item
//     --
// Your program should read in the user's input and determine if it begins with a “+” or “-“ or
// if it is simply “—“ . In the first two cases, your program should add or remove the string
// given ("some item" in the example). If the user enters just “—“ then the program should
// clear the current list. Your program can start each iteration through its loop with the
//     following instruction:
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
ListManager myListManager = new ListManager();
myListManager.Run();   //type "exit" to stop the iteration



// 3. Write a method that calculates all prime numbers in given range and returns them as array
// of integers
// static int[] FindPrimesInRange(startNum, endNum)
// {
// }
int startNum = 1, endNum = 100;
int[] results3 = PrimeFinder.FindPrimesInRange(startNum, endNum);
Console.WriteLine($"Primes numbers between {startNum} and {endNum}:" + String.Join(",", results3));



// 4. Write a program to read an array of n integers (space separated on a single line) and an
// integer k, rotate the array right k times and sum the obtained arrays after each rotation as shown below.
// After r rotations the element at position I goes to position (I + r) % n.
// The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1
string inputArray = "1 2 3 4 5";
int k = 3;
int[] result4 = RotateSum.solve(inputArray, k);
Console.WriteLine("The result is: " + String.Join(",", result4));


// 5. Write a program that finds the longest sequence of equal elements in an array of integers.
//     If several longest sequences exist, print the leftmost one.
int[] array5 = new int[] { 0, 1, 1, 5, 2, 2, 6, 3, 3};
int[] result5 = LongestSequence.FindLongestEqualSequence(array5);
Console.WriteLine("The result is: " + String.Join(",", result5));


// 7. Write a program that finds the most frequent number in a given sequence of numbers. In
// case of multiple numbers with the same maximal frequency, print the leftmost of them
int[] array7 = new int[] { 0, 1, 1, 5, 2, 2, 6, 3, 3};
int result7 = MostFrequent.FindMostFrequent(array7);
Console.WriteLine("The Most frequent number is: " + result7.ToString());


// Practice Strings
// 1. Write a program that reads a string from the console, reverses its letters and prints the
//     result back at the console.
//     Write in two ways
// Convert the string to char array, reverse it, then convert it to string again
// Print the letters of the string in back direction (from the last to the first) in a for-loop
string str1 = "qwertyu";
ReverseLetters.printReversed(str1);


// 2. Write a program that reverses the words in a given sentence without changing the
// punctuation and spaces
//     Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
//     All other characters are considered part of words, e.g. C++, a+b, and a77 are
//     considered valid words.
//     The sentences always start by word and end by separator
string str2 = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
Console.WriteLine(ReverseString.Reverse(str2));


// 3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
// and prints them on the console on a single line, separated by comma and space.Print all
// unique palindromes (no duplicates), sorted
string str3 = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
Console.WriteLine(String.Join(", ", PalindromesGet.ExtractAndSortPalindromes(str3)));


// 4. Write a program that parses an URL given in the following format:
// [protocol]://[server]/[resource]
// The parsing extracts its parts: protocol, server and resource.
//     The [server] part is mandatory.
//     The [protocol] and [resource] parts are optional.
string str4 = "https://www.apple.com/iphone";
URLParser.ParseUrl(str4);