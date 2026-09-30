/*
* Name: Chase McBee
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/


//rng code for Part 2
Random rng = new Random();


// Part 1: The Name
// Description: Parses for a badge name, username, initials, and letters in a last name.

Console.WriteLine("Please type your name: ");
string fullName = Console.ReadLine();

fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string badgeName = fullName.ToUpper();

string userNameInitial = fullName.Substring(0,1).ToLower();
string userNameLast = lastName.ToLower();
string userName = userNameInitial + userNameLast;

string firstInitial = firstName.Substring(0,1).ToUpper();
string lastInitial = lastName.Substring(0,1).ToUpper();

int lastNameLetters = lastName.Length;

Console.WriteLine($"\nFull name: {fullName}");
Console.WriteLine($"Name on badge: {badgeName}");
Console.WriteLine($"Username: {userNameInitial}{userNameLast}");
Console.WriteLine($"Initials: {firstInitial}.{lastInitial}.");
Console.WriteLine($"Letters in last name: {lastNameLetters}");

// Part 2: The Numbers
// Description: Prints a randomly generated ID number and locker number via a Random object.

int studentID = rng.Next(100000,1000000);
Console.WriteLine($"\nStudent ID: {studentID}");
int lockerNumber= rng.Next(1,501);
Console.WriteLine($"Locker Number: {lockerNumber}");

// Part 3: The Walk
// Description: Prints distance and walk time for a student walking to a class via Math methods.

Console.WriteLine("\nPlease type the dorms X coordinate value: ");
double dormX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please type the dorms Y coordinate value: ");
double dormY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please type the classroom's X coordinate value: ");
double classX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please type the classroom's Y coordinate value: ");
double classY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please type the student walking speed, in feet per second: ");
double walkSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(classX - dormX,2) + Math.Pow(classY - dormY,2));

double tripInSeconds = distance / walkSpeed;

Console.WriteLine($"Distance: {Math.Round(distance, 1)} feet.");
int walkMinutes = Convert.ToInt32(tripInSeconds / 60);
int walkSeconds = Convert.ToInt32(tripInSeconds % 60);
Console.WriteLine($"Walk time: {walkMinutes} minutes and {walkSeconds} seconds.");

// Part 4: The Badge
// Description: Prints off a completed badge using the info provided in the previous parts.
int checkDigit = studentID % 9;

Console.WriteLine("\n");
Console.WriteLine(new string('=', 34));
Console.WriteLine("STUDENT BADGE");
Console.WriteLine(new string('=', 34));
Console.WriteLine("NAME".PadRight(10) + badgeName);
Console.WriteLine("USERNAME".PadRight(10) + userName);
Console.WriteLine("ID".PadRight(10) + $"{studentID}-{checkDigit}");
Console.WriteLine("LOCKER".PadRight(10) + lockerNumber);
Console.WriteLine("WALK".PadRight(10) + $"{walkMinutes} min {walkSeconds} sec");
Console.WriteLine(new string('=', 34));


