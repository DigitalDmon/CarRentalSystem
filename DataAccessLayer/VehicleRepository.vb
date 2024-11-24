Imports System.Data.SqlClient

Public Class VehicleDataAccess
    Private ReadOnly dbConnection As New DatabaseConnection()

    Public Function GetAllVehicles() As List(Of Vehicle)
        Dim vehicles As New List(Of Vehicle)()
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM vehicles"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim vehicle As New Vehicle With {
                                .IdVehicle = Convert.ToInt32(reader("id_vehicle")),
                                .Brand = reader("brand").ToString(),
                                .Model = reader("model").ToString(),
                                .Year = Convert.ToInt32(reader("year")),
                                .Plate = reader("plate").ToString(),
                                .Fuel = reader("fuel").ToString()
                            }
                            vehicles.Add(vehicle)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de vehículos: " & ex.Message)
        End Try
        Return vehicles
    End Function

    ' Método para registrar un vehículo
    Public Function RegisterVehicle(vehicle As Vehicle) As Boolean
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO vehicles (brand, model, year, plate, fuel) VALUES (@brand, @model, @year, @plate, @fuel)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@brand", vehicle.Brand)
                    cmd.Parameters.AddWithValue("@model", vehicle.Model)
                    cmd.Parameters.AddWithValue("@year", vehicle.Year)
                    cmd.Parameters.AddWithValue("@plate", vehicle.Plate)
                    cmd.Parameters.AddWithValue("@fuel", vehicle.Fuel)
                    cmd.ExecuteNonQuery()
                End Using
                Return True
            End Using
        Catch ex As Exception
            ' Manejo de errores
            Throw New Exception("Error al registrar el vehículo: " & ex.Message)
        End Try
    End Function

    ' Método para actualizar un vehículo
    Public Function UpdateVehicle(vehicle As Vehicle) As Boolean
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE vehicles SET brand = @brand, model = @model, year = @year, plate = @plate, fuel = @fuel WHERE id_vehicle = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@brand", vehicle.Brand)
                    cmd.Parameters.AddWithValue("@model", vehicle.Model)
                    cmd.Parameters.AddWithValue("@year", vehicle.Year)
                    cmd.Parameters.AddWithValue("@plate", vehicle.Plate)
                    cmd.Parameters.AddWithValue("@fuel", vehicle.Fuel)
                    cmd.Parameters.AddWithValue("@id", vehicle.IdVehicle)
                    cmd.ExecuteNonQuery()
                End Using
                Return True
            End Using
        Catch ex As Exception
            ' Manejo de errores
            Throw New Exception("Error al actualizar el vehículo: " & ex.Message)
        End Try
    End Function

End Class
