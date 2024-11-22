Public Class BookingManager
    Private ReadOnly bookingRepository As New BookingRepository()

    Public Function RegisterBooking(idCustomer As Integer, idVehicle As Integer, dateStart As Date, dateEnd As Date) As Boolean
        Return bookingRepository.InsertBooking(idCustomer, idVehicle, dateStart, dateEnd)
    End Function


    Public Function UpdateBooking(idBooking As Integer, idCustomer As Integer, idVehicle As Integer, dateBooking As Date, dateStart As Date, dateEnd As Date) As Boolean
        Return bookingRepository.UpdateBooking(idBooking, idCustomer, idVehicle, dateStart, dateEnd)
    End Function

    Public Function DeleteBooking(idBooking As Integer) As Boolean
        Return bookingRepository.DeleteBooking(idBooking)
    End Function

    Public Function GetBookings() As DataSet
        Return bookingRepository.GetBookings()
    End Function

    Public Function GetCustomers() As DataTable
        Return bookingRepository.GetCustomers()
    End Function

    Public Function GetVehicles() As DataTable
        Return bookingRepository.GetVehicles()
    End Function

End Class
