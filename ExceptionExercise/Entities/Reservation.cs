using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise.Entities
{
	internal class Reservation
	{
		public int RoomNumber { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }

		public Reservation() { }

		public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
		{
			RoomNumber = roomNumber;
			CheckIn = checkIn;
			CheckOut = checkOut;
		}

		public int Duration()
		{
			TimeSpan duration = CheckOut.Subtract(CheckIn);
			return (int)duration.TotalDays;
		}

		public override string ToString()
		{
			return $"Room {RoomNumber}, check-in: {CheckIn:dd/MM/yyyy}, check-out: {CheckOut:dd/MM/yyyy}";
		}
	}
}
