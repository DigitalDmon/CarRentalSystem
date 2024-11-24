Public Class BookingManager
    Private ReadOnly bookingRepository As New BookingRepository()

    Public Function GetAllBookings() As List(Of Booking)
        Return bookingRepository.GetAllBookings()
    End Function

    Public Function RegisterBooking(booking As Booking) As Boolean
        Return bookingRepository.RegisterBooking(booking)
    End Function

    Public Function UpdateBooking(booking As Booking) As Boolean
        Return bookingRepository.UpdateBooking(booking)
    End Function
End Class
