Imports System.Data.SqlClient

Public Class MaintenanceRepository

    Private ReadOnly connection As New DatabaseConnection()

    ' Obtener todos los mantenimientos
    Public Function GetAllMaintenances() As List(Of Maintenance)
        Dim maintenances As New List(Of Maintenance)()

        Try
            Using conn As SqlConnection = connection.GetConnection()
                conn.Open()

                ' Consultar todos los registros de la tabla maintenances
                Dim query As String = "SELECT * FROM maintenances"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Crear un objeto de mantenimiento y agregarlo a la lista
                            Dim maintenance As New Maintenance() With {
                                .IdMaintenance = reader.GetInt32(0),
                                .IdVehicle = reader.GetInt32(1),
                                .IdMechanic = reader.GetInt32(2),
                                .MaintenanceDate = reader.GetDateTime(3),
                                .Description = reader.GetString(4),
                                .Cost = reader.GetDecimal(5)
                            }
                            maintenances.Add(maintenance)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los mantenimientos: " & ex.Message)
        End Try

        Return maintenances
    End Function

    ' Registrar mantenimiento
    Public Sub RegisterMaintenance(maintenance As Maintenance)
        Try
            Using conn As SqlConnection = connection.GetConnection()
                conn.Open()

                Dim query As String = "INSERT INTO maintenances (id_vehicle, id_mechanic, description, cost) " &
                                      "VALUES (@id_vehicle, @id_mechanic, @description, @cost)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_vehicle", maintenance.IdVehicle)
                    cmd.Parameters.AddWithValue("@id_mechanic", maintenance.IdMechanic)
                    cmd.Parameters.AddWithValue("@description", maintenance.Description)
                    cmd.Parameters.AddWithValue("@cost", maintenance.Cost)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al registrar el mantenimiento: " & ex.Message)
        End Try
    End Sub

    ' Actualizar mantenimiento
    Public Function UpdateMaintenance(maintenance As Maintenance) As Boolean
        Try
            Using conn As SqlConnection = connection.GetConnection()
                conn.Open()

                Dim query As String = "UPDATE maintenances SET id_vehicle = @id_vehicle, id_mechanic = @id_mechanic, " &
                                      "description = @description, cost = @cost " &
                                      "WHERE id_maintenance = @id_maintenance"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_maintenance", maintenance.IdMaintenance)
                    cmd.Parameters.AddWithValue("@id_vehicle", maintenance.IdVehicle)
                    cmd.Parameters.AddWithValue("@id_mechanic", maintenance.IdMechanic)
                    cmd.Parameters.AddWithValue("@description", maintenance.Description)
                    cmd.Parameters.AddWithValue("@cost", maintenance.Cost)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al actualizar el mantenimiento: " & ex.Message)
        End Try
    End Function

End Class
