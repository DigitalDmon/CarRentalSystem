Imports System.Data.SqlClient

Public Class DatabaseConnection

    ' Cadena de conexión (puede ser leída desde un archivo de configuración)
    Private connectionString As String = "Data Source=ELADIO-LAPTOP;Initial Catalog=CarRental_DB;Integrated Security=True"

    ' Método para abrir y realizar una consulta
    Public Function ObtenerDatos(query As String) As DataTable
        ' Crear una tabla para almacenar los resultados
        Dim dataTable As New DataTable()

        ' Usar la conexión y el comando dentro de bloques Using para asegurar el cierre de recursos
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Ejecutar el comando y llenar la tabla con los resultados
                    Using reader As SqlDataReader = command.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                Catch ex As Exception
                    ' Manejo de errores
                    MessageBox.Show($"Error al conectar: {ex.Message}")
                End Try
            End Using
        End Using

        ' Devolver la tabla de datos
        Return dataTable
    End Function
End Class