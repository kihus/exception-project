using ExceptionExercise.Entities;
using ExceptionExercise.Entities.Exceptions;
using System.Globalization;

try
{
	Console.Write("Room number: ");
	var number = int.Parse(Console.ReadLine() ?? "0");

	Console.Write("Check-in date (dd/MM/yyyy): ");
	var checkIn = DateTime.ParseExact(Console.ReadLine() ?? "0", "dd/MM/yyyy", CultureInfo.InvariantCulture);

	Console.Write("Check-out date (dd/MM/yyyy): ");
	var checkOut = DateTime.ParseExact(Console.ReadLine() ?? "0", "dd/MM/yyyy", CultureInfo.InvariantCulture);

	var reservation = new RegisterReserve(number, checkIn, checkOut);
	Console.WriteLine("Reservation: " + reservation);
	Console.WriteLine();

	Console.WriteLine("Enter data to update the reservation: ");
	Console.Write("Check-on date (dd/MM/yyyy): ");
	checkIn = DateTime.ParseExact(Console.ReadLine() ?? "0", "dd/MM/yyyy", CultureInfo.InvariantCulture);
	Console.Write("Check-out date (dd/MM/yyyy): ");
	checkOut = DateTime.ParseExact(Console.ReadLine() ?? "0", "dd/MM/yyyy", CultureInfo.InvariantCulture);

	reservation.UpdateDate(checkIn, checkOut);

	Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
	Console.WriteLine("Error in reservation: " + e.Message);
}
