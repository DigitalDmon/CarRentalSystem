Public Class VehicleManager
    Private ReadOnly vehicleData As New VehicleDataAccess()

    Public Function GetAllVehicles() As List(Of Vehicle)
        Return vehicleData.GetAllVehicles()
    End Function

    ' Lógica para registrar un vehículo
    Public Function RegisterVehicle(vehicle As Vehicle) As Boolean
        If String.IsNullOrEmpty(vehicle.Brand) OrElse
           String.IsNullOrEmpty(vehicle.Model) OrElse
           String.IsNullOrEmpty(vehicle.Plate) OrElse
           String.IsNullOrEmpty(vehicle.Fuel) OrElse
           vehicle.Year <= 0 Then
            Throw New ArgumentException("Todos los campos son obligatorios y deben ser válidos.")
        End If
        Return vehicleData.RegisterVehicle(vehicle)
    End Function

    ' Lógica para actualizar un vehículo
    Public Function UpdateVehicle(vehicle As Vehicle) As Boolean
        If vehicle.IdVehicle <= 0 Then
            Throw New ArgumentException("El ID del vehículo es inválido.")
        End If
        If String.IsNullOrEmpty(vehicle.Brand) OrElse
           String.IsNullOrEmpty(vehicle.Model) OrElse
           String.IsNullOrEmpty(vehicle.Plate) OrElse
           String.IsNullOrEmpty(vehicle.Fuel) OrElse
           vehicle.Year <= 0 Then
            Throw New ArgumentException("Todos los campos son obligatorios y deben ser válidos.")
        End If
        Return vehicleData.UpdateVehicle(vehicle)
    End Function
End Class
