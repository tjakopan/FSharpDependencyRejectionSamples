module BookingApi.MaitreD

open System

type Reservation =
  { Date: DateTimeOffset
    Quantity: int
    IsAccepted: bool }

let tryAccept capacity reservations reservation =
  let reservedSeats = reservations |> List.sumBy (_.Quantity)

  if reservedSeats + reservation.Quantity <= capacity then
    { reservation with IsAccepted = true } |> Some
  else
    None
