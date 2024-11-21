Imports System.Data.SqlClient

Public Class ClientRepository

    ' Conexión a la base de datos
    Private ReadOnly dbConnection As New DatabaseConnection()

    ' Método Obtener todos los clientes
    Public Function GetAllClients() As DataSet
        Dim dataSet As New DataSet()
        Try
            Using connection As SqlConnection = dbConnection.GetConnection()
                Dim query As String = "SELECT * FROM customers"
                Dim adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataSet, "customers")
            End Using
        Catch ex As SqlException
            Throw New ApplicationException("Error fetching clients from the database.", ex)
        End Try
        Return dataSet
    End Function


    ' Método para agregar un nuevo cliente
    Public Sub RegisterClient(name As String, lastname As String, identity_number As String, phone_number As String, email As String)

        ' Query para insertar un nuevo cliente
        Dim query As String = "INSERT INTO customers (name, lastname, identity_number, phone_number, email) VALUES (@name, @lastname, @identity_number, @phone_number, @email)"

        ' Usar la conexión a la base de datos
        Using connection As SqlConnection = dbConnection.GetConnection()

            ' Crear un nuevo comando SQL
            Using command As New SqlCommand(query, connection)

                ' Agregar los parámetros necesarios
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@lastname", lastname)
                command.Parameters.AddWithValue("@identity_number", identity_number)
                command.Parameters.AddWithValue("@phone_number", phone_number)
                command.Parameters.AddWithValue("@email", email)

                ' Abrir la conexión
                connection.Open()
                ' Ejecutar el comando SQL
                command.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Sub DeleteClient(clientId As Integer)
        Dim query As String = "DELETE FROM customers WHERE id_customer = @id"

        Using connection As SqlConnection = dbConnection.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", clientId)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateClient(clientId As Integer, name As String, lastname As String, identity_number As String, phone_number As String, email As String)
        Dim query As String = "UPDATE customers SET name = @name, lastname = @lastname, identity_number = @identity_number, phone_number = @phone_number, email = @email WHERE id_customer = @id"

        Using connection As SqlConnection = dbConnection.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", clientId)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@lastname", lastname)
                command.Parameters.AddWithValue("@identity_number", identity_number)
                command.Parameters.AddWithValue("@phone_number", phone_number)
                command.Parameters.AddWithValue("@email", email)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Class
