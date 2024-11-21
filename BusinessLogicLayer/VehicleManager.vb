Imports System.Data

Public Class VehicleManager

    Private ReadOnly vehicleRepository As New VehicleRepository()

    ' Método para obtener todos los vehículos
    Public Function GetVehicles() As DataSet
        Try
            Return vehicleRepository.GetAllVehicles()
        Catch ex As Exception
            Throw New ApplicationException("Error while fetching vehicles.", ex)
        End Try
    End Function

    ' Método para registrar un vehículo
    Public Function RegisterVehicle(brand As String, model As String, year As Integer, plate As String, fuel As String) As Boolean
        ' Validar datos
        If String.IsNullOrWhiteSpace(brand) OrElse
           String.IsNullOrWhiteSpace(model) OrElse
           year <= 0 OrElse
           String.IsNullOrWhiteSpace(plate) OrElse
           String.IsNullOrWhiteSpace(fuel) Then
            Throw New ArgumentException("All fields must be filled in.")
        End If

        ' Intentar registrar
        Try
            vehicleRepository.AddVehicle(brand, model, year, plate, fuel)
            Return True
        Catch ex As Exception
            Throw New ApplicationException("Error while registering the vehicle.", ex)
        End Try
    End Function

    ' Método para actualizar un vehículo
    Public Function UpdateVehicle(id_vehicle As Integer, brand As String, model As String, year As Integer, plate As String, fuel As String) As Boolean
        ' Validar datos
        If id_vehicle <= 0 OrElse
           String.IsNullOrWhiteSpace(brand) OrElse
           String.IsNullOrWhiteSpace(model) OrElse
           year <= 0 OrElse
           String.IsNullOrWhiteSpace(plate) OrElse
           String.IsNullOrWhiteSpace(fuel) Then
            Throw New ArgumentException("All fields must be filled in.")
        End If

        ' Intentar actualizar
        Try
            vehicleRepository.UpdateVehicle(id_vehicle, brand, model, year, plate, fuel)
            Return True
        Catch ex As Exception
            Throw New ApplicationException("Error while updating the vehicle.", ex)
        End Try
    End Function

    ' Método para eliminar un vehículo
    Public Function DeleteVehicle(id_vehicle As Integer) As Boolean
        If id_vehicle <= 0 Then
            Throw New ArgumentException("Invalid vehicle ID.")
        End If

        ' Intentar eliminar
        Try
            vehicleRepository.DeleteVehicle(id_vehicle)
            Return True
        Catch ex As Exception
            Throw New ApplicationException("Error while deleting the vehicle.", ex)
        End Try
    End Function

End Class
