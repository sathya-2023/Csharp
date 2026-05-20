//Calling the Methods in .Net class
// 2 types of methods: Stateless and Stateful

// Stateless methods: Do not rely on any internal state or data
Console.WriteLine("Hello, World!"); // This is a stateless method because it simply takes the input string and outputs it to the console without any dependency on internal state or data. And it is called without needing to create an instance of a class.

// Stateful methods: Rely on internal state or data to produce output, have to create an instance of the class
// 1. Create the instance (the object) in memory
Random dice = new Random();

// 2. Call the method off that specific object
int roll = dice.Next(1, 7); //we are calling the Next method here
Console.WriteLine($"You rolled a {roll}");

