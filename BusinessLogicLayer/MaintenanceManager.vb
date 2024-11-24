Public Class MaintenanceManager

    Private ReadOnly maintenanceRepository As New MaintenanceRepository()

    ' Obtener todos los mantenimientos
    Public Function GetAllMaintenances() As List(Of Maintenance)
        Return maintenanceRepository.GetAllMaintenances()
    End Function

    ' Registrar mantenimiento
    Public Sub RegisterMaintenance(maintenance As Maintenance)
        maintenanceRepository.RegisterMaintenance(maintenance)
    End Sub

    ' Actualizar mantenimiento
    Public Function UpdateMaintenance(maintenance As Maintenance) As Boolean
        Return maintenanceRepository.UpdateMaintenance(maintenance)
    End Function

End Class
