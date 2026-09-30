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
// Description: Parses for a badge name, username, initials, and letters in a last name

Console.WriteLine("Please type your name: ");
string fullName = Console.ReadLine();

fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string badgeName = fullName.ToUpper();

string userNameInitial = fullName.Substring(0,1).ToLower();
string userNameLast = lastName.ToLower();

string firstInitial = firstName.Substring(0,1).ToUpper();
string lastInitial = lastName.Substring(0,1).ToUpper();

int lastNameLetters = lastName.Length;

Console.WriteLine($"Name on badge: {badgeName}");
Console.WriteLine($"Username: {userNameInitial}{userNameLast}");
Console.WriteLine($"Initials: {firstInitial}.{lastInitial}.");
Console.WriteLine($"Letters in last name: {lastNameLetters}");

// Part 2: The Numbers
// Description: Adds a randomly generated ID number and locker number via a Random object.

int studentID = rng.Next(100000,1000000);
Console.WriteLine($"\nStudent ID: {studentID}");
int lockerNumber= rng.Next(1,501);
Console.WriteLine($"\nStudent ID: {lockerNumber}");