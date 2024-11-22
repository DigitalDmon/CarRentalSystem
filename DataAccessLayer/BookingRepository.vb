Imports System.Data.SqlClient

Public Class BookingRepository
    Private ReadOnly dbConnection As New DatabaseConnection()

    Public Function InsertBooking(idCustomer As Integer, idVehicle As Integer, dateStart As Date, dateEnd As Date) As Boolean
        Dim query = "INSERT INTO bookings (id_customer, id_vehicle, date_start, date_end, status) VALUES (@id_customer, @id_vehicle, @date_start, @date_end)"
        Using connection = dbConnection.GetConnection()
            Using command = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_customer", idCustomer)
                command.Parameters.AddWithValue("@id_vehicle", idVehicle)
                command.Parameters.AddWithValue("@date_start", dateStart)
                command.Parameters.AddWithValue("@date_end", dateEnd)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function UpdateBooking(idBooking As Integer, idCustomer As Integer, idVehicle As Integer, dateStart As Date, dateEnd As Date) As Boolean
        Dim query = "UPDATE bookings SET id_customer = @id_customer, id_vehicle = @id_vehicle, date_start = @date_start, date_end = @date_end WHERE id_booking = @id_booking"
        Using connection = dbConnection.GetConnection()
            Using command = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_booking", idBooking)
                command.Parameters.AddWithValue("@id_customer", idCustomer)
                command.Parameters.AddWithValue("@id_vehicle", idVehicle)
                command.Parameters.AddWithValue("@date_start", dateStart)
                command.Parameters.AddWithValue("@date_end", dateEnd)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DeleteBooking(idBooking As Integer) As Boolean
        Dim query = "DELETE FROM bookings WHERE id_booking = @id_booking"
        Using connection = dbConnection.GetConnection()
            Using command = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_booking", idBooking)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetBookings() As DataSet
        Dim query = "SELECT * FROM bookings"
        Dim dataSet As New DataSet()
        Using connection = dbConnection.GetConnection()
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataSet, "bookings")
            End Using
        End Using
        Return dataSet
    End Function

    Public Function GetCustomers() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id_customer, name FROM customers"
                Using cmd As New SqlCommand(query, conn)
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error retrieving customers: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GetVehicles() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id_vehicle, brand FROM vehicles"
                Using cmd As New SqlCommand(query, conn)
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error retrieving vehicles: " & ex.Message)
        End Try

        Return dt
    End Function

End Class
