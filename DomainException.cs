﻿namespace ReservationProject;

public class DomainException : ApplicationException
{
  public DomainException(string message)
    : base(message)
  {

  }
}
