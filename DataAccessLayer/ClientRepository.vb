Imports System.Data.SqlClient
Imports System.Data

Public Class ClientRepository

    Private ReadOnly connection As New DatabaseConnection()

    Public Function GetAll() As List(Of Customer)

        Dim customers As New List(Of Customer)()
        Dim query As String = "SELECT * FROM customers"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim customer As New Customer With {
                            .IdCustomer = Convert.ToInt32(reader("id_customer")),
                            .Name = reader("name").ToString(),
                            .Lastname = reader("lastname").ToString(),
                            .IdentityNumber = reader("identity_number").ToString(),
                            .PhoneNumber = reader("phone_number").ToString(),
                            .Email = reader("email").ToString()
                        }
                        customers.Add(customer)
                    End While
                End Using
            End Using
        End Using

        Return customers
    End Function

    Public Function Insert(customer As Customer) As Boolean

        Dim query As String = "INSERT INTO customers (name, lastname, identity_number, phone_number, email) VALUES (@name, @lastname, @identity_number, @phone_number, @email)"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", customer.Name)
                cmd.Parameters.AddWithValue("@lastname", customer.Lastname)
                cmd.Parameters.AddWithValue("@identity_number", customer.IdentityNumber)
                cmd.Parameters.AddWithValue("@phone_number", customer.PhoneNumber)
                cmd.Parameters.AddWithValue("@email", customer.Email)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Delete(customerId As Integer) As Boolean
        Dim query As String = "DELETE FROM customers WHERE id_customer = @id_customer"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_customer", customerId)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Update(customer As Customer) As Boolean
        Dim query As String = "UPDATE customers SET name = @name, lastname = @lastname, identity_number = @identity_number, phone_number = @phone_number, email = @email WHERE id_customer = @id_customer"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", customer.Name)
                cmd.Parameters.AddWithValue("@lastname", customer.Lastname)
                cmd.Parameters.AddWithValue("@identity_number", customer.IdentityNumber)
                cmd.Parameters.AddWithValue("@phone_number", customer.PhoneNumber)
                cmd.Parameters.AddWithValue("@email", customer.Email)
                cmd.Parameters.AddWithValue("@id_customer", customer.IdCustomer)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function



End Class
