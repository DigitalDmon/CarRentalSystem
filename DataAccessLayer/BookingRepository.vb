Imports System.Data.SqlClient

Public Class BookingRepository
    Private ReadOnly dbConnection As New DatabaseConnection()

    Public Function GetAllBookings() As List(Of Booking)
        Dim bookings As New List(Of Booking)()
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM bookings"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim booking As New Booking With {
                                .IdBooking = Convert.ToInt32(reader("id_booking")),
                                .IdCustomer = Convert.ToInt32(reader("id_customer")),
                                .IdVehicle = Convert.ToInt32(reader("id_vehicle")),
                                .DateBooking = Convert.ToDateTime(reader("date_booking")),
                                .DateStart = Convert.ToDateTime(reader("date_start")),
                                .DateEnd = Convert.ToDateTime(reader("date_end"))
                            }
                            bookings.Add(booking)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las reservas: " & ex.Message)
        End Try
        Return bookings
    End Function

    Public Function RegisterBooking(booking As Booking) As Boolean
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO bookings (id_customer, id_vehicle, date_start, date_end) VALUES (@id_customer, @id_vehicle, @date_start, @date_end)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_customer", booking.IdCustomer)
                    cmd.Parameters.AddWithValue("@id_vehicle", booking.IdVehicle)
                    cmd.Parameters.AddWithValue("@date_start", booking.DateStart)
                    cmd.Parameters.AddWithValue("@date_end", booking.DateEnd)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al registrar la reserva: " & ex.Message)
        End Try
    End Function

    Public Function UpdateBooking(booking As Booking) As Boolean
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE bookings SET id_customer = @id_customer, id_vehicle = @id_vehicle, date_start = @date_start, date_end = @date_end WHERE id_booking = @id_booking"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_booking", booking.IdBooking)
                    cmd.Parameters.AddWithValue("@id_customer", booking.IdCustomer)
                    cmd.Parameters.AddWithValue("@id_vehicle", booking.IdVehicle)
                    cmd.Parameters.AddWithValue("@date_start", booking.DateStart)
                    cmd.Parameters.AddWithValue("@date_end", booking.DateEnd)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al actualizar la reserva: " & ex.Message)
        End Try
    End Function
End Class