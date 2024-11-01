Imports System.Data.SqlClient

Public Class DatabaseConnection

    Private ReadOnly connectionString As String = "Data Source=ELADIO-LAPTOP;Initial Catalog=CarRental_DB;Integrated Security=True"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class