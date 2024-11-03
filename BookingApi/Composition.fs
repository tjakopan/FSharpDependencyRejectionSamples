module BookingApi.Composition

module DB =
  let readReservations connectionString date = []
  let createReservation connectionString reservation = 0

let connectionString = ""

let flip f x y = f y x

let tryAcceptComposition (reservation: MaitreD.Reservation) =
  reservation.Date
  |> DB.readReservations connectionString
  |> flip (MaitreD.tryAccept 10) reservation
  |> Option.map (DB.createReservation connectionString)
