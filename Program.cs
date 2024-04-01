// See https://aka.ms/new-console-template for more information
using ReservationProject;

try
{
  Console.Write("Room number: ");
  int roomNumber = Convert.ToInt32(Console.ReadLine());

  Console.Write("Checkin date(dd/MM/yy): ");
  DateTime checkin = DateTime.Parse(Console.ReadLine());

  Console.Write("Checkout date(dd/MM/yy): ");
  DateTime checkout = DateTime.Parse(Console.ReadLine());


  Reservation reservation = new Reservation(roomNumber, checkin, checkout);

  System.Console.WriteLine(reservation);

  System.Console.WriteLine();
  System.Console.WriteLine("Enter the date to update the reservation:");
  Console.Write("Checkin date(dd/MM/yy): ");
  checkin = DateTime.Parse(Console.ReadLine());

  Console.Write("Checkout date(dd/MM/yy): ");
  checkout = DateTime.Parse(Console.ReadLine());
  reservation.UpdateDates(checkin, checkout);

  System.Console.WriteLine(reservation);
}
catch (DomainException domainException)
{
  System.Console.WriteLine($"Personal Error: {domainException.Message}");
}
catch (Exception exception)
{
  System.Console.WriteLine($"Format error: {exception.Message}");
}