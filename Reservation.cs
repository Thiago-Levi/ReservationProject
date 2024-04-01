namespace ReservationProject;

public class Reservation
{

  public int RoomNumber { get; set; }
  public DateTime Checkin { get; set; }
  public DateTime Checkout { get; set; }

  public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
  {
    if (checkout <= checkin)
    {
      throw new DomainException("Check-out date must be after check-in date!");
    }

    RoomNumber = roomNumber;
    Checkin = checkin;
    Checkout = checkout;
  }

  public int Duration()
  {
    TimeSpan durationInTimeSpan = Checkout.Subtract(Checkin);
    int totalDaysOfReservation = (int)durationInTimeSpan.TotalDays;
    System.Console.WriteLine(totalDaysOfReservation);

    return totalDaysOfReservation;
  }

  public void UpdateDates(DateTime checkin, DateTime checkout)
  {

    DateTime now = DateTime.Now;

    if (checkin < now || checkout < now)
    {
      throw new DomainException("Reservation dates for update must be future dates!");
    }
    if (checkout <= checkin)
    {
      throw new DomainException("Check-out date must be after check-in date!");
    }
    Checkin = checkin;
    Checkout = checkout;
  }

  public override string ToString()
  {
    return $"Reservation: Romm: {RoomNumber}, Check-in: {Checkin:d}, Check-out: {Checkout:d}, {Duration()} nights";
  }


}