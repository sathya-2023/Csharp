// ========================================
// Student Grade Calculator
// ========================================
// This program demonstrates core C# concepts:
// 1. Variable declaration and initialization
// 2. Data types (int, decimal)
// 3. Arithmetic operations
// 4. Type casting
// 5. String concatenation
// 6. Console output formatting
// ========================================

// Variable Declaration: Using 'int' data type to store whole numbers
// This stores the total number of assignments for calculating averages
int currentAssignments = 5;

// Declaring and initializing variables for Sophia's assignment scores
// Each variable stores an integer value representing a grade (0-100)
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

// Nicolas's assignment scores
int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

// Zahirah's assignment scores
int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

// Jeong's assignment scores
int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// Arithmetic Operations: Using the + operator to calculate sum of all assignments
// The result is stored in an int variable since we're adding integers
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// Type Casting: Converting int to decimal for precise division
// Without casting, int/int would result in integer division (truncated result)
// Example: 417/5 as int = 83, but 417/5 as decimal = 83.4
// Syntax: (decimal) casts the int value to decimal before division
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

// Console Output: Displaying results to the terminal
// \t represents a tab character for alignment
// \n represents a newline character
Console.WriteLine("Student\t\tGrade\n");

// String Concatenation: Using the + operator to combine strings and variables
// The decimal scores are automatically converted to strings during concatenation
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");