using ExceptionExercise.Entities;

Console.Write("Room number: ");
var number = int.Parse(Console.ReadLine());

Console.Write("Check-in date (dd/MM/yyyy): ");
var checkIn = DateTime.Parse(Console.ReadLine());

Console.Write("Check-out date (dd/MM/yyyy): ");
var checkOut = DateTime.Parse(Console.ReadLine());

var reservation = new Reservation(number, checkIn, checkOut);


