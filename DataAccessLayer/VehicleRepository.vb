Imports System.Data.SqlClient

Public Class VehicleRepository

    ' Conexión a la base de datos
    Private ReadOnly dbConnection As New DatabaseConnection()

    ' Obtener todos los vehículos
    Public Function GetAllVehicles() As DataSet
        Dim query As String = "SELECT * FROM vehicles"
        Dim dataSet As New DataSet()

        Using connection As SqlConnection = dbConnection.GetConnection()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(dataSet, "vehicles")
        End Using

        Return dataSet
    End Function

    ' Agregar un vehículo
    Public Sub AddVehicle(brand As String, model As String, year As Integer, plate As String, fuel As String)
        Dim query As String = "INSERT INTO vehicles (brand, model, year, plate, fuel) VALUES (@brand, @model, @year, @plate, @fuel)"

        Using connection As SqlConnection = dbConnection.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@brand", brand)
                command.Parameters.AddWithValue("@model", model)
                command.Parameters.AddWithValue("@year", year)
                command.Parameters.AddWithValue("@plate", plate)
                command.Parameters.AddWithValue("@fuel", fuel)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Actualizar un vehículo
    Public Sub UpdateVehicle(id_vehicle As Integer, brand As String, model As String, year As Integer, plate As String, fuel As String)
        Dim query As String = "UPDATE vehicles SET brand = @brand, model = @model, year = @year, plate = @plate, fuel = @fuel WHERE id_vehicle = @id_vehicle"

        Using connection As SqlConnection = dbConnection.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_vehicle", id_vehicle)
                command.Parameters.AddWithValue("@brand", brand)
                command.Parameters.AddWithValue("@model", model)
                command.Parameters.AddWithValue("@year", year)
                command.Parameters.AddWithValue("@plate", plate)
                command.Parameters.AddWithValue("@fuel", fuel)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar un vehículo
    Public Sub DeleteVehicle(id_vehicle As Integer)
        Dim query As String = "DELETE FROM vehicles WHERE id_vehicle = @id_vehicle"

        Using connection As SqlConnection = dbConnection.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_vehicle", id_vehicle)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
