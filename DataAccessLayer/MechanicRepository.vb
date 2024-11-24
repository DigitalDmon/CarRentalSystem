Imports System.Data.SqlClient

Public Class MechanicResponsitory

    Private dbConnection As New DatabaseConnection()

    Public Function GetAllMechanics() As List(Of Mechanic)
        Dim mechanics As New List(Of Mechanic)()
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM mechanics"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim mechanic As New Mechanic With {
                                .IdMechanic = Convert.ToInt32(reader("id_mechanic")),
                                .Name = reader("name").ToString(),
                                .Lastname = reader("lastname").ToString(),
                                .Speciality = reader("speciality").ToString(),
                                .Phone = reader("phone").ToString(),
                                .IdentityNumber = reader("identity_number").ToString()
                            }
                            mechanics.Add(mechanic)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de mecánicos: " & ex.Message)
        End Try
        Return mechanics
    End Function

    Public Function RegisterMechanic(mechanic As Mechanic) As Boolean
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO mechanics (name, lastname, speciality, phone, identity_number) VALUES (@name, @lastname, @speciality, @phone, @identity_number)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", mechanic.Name)
                    cmd.Parameters.AddWithValue("@lastname", mechanic.Lastname)
                    cmd.Parameters.AddWithValue("@speciality", mechanic.Speciality)
                    cmd.Parameters.AddWithValue("@phone", mechanic.Phone)
                    cmd.Parameters.AddWithValue("@identity_number", mechanic.IdentityNumber)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al registrar el mecánico: " & ex.Message)
        End Try
    End Function

    Public Function UpdateMechanic(mechanic As Mechanic) As Boolean
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE mechanics SET name = @name, lastname = @lastname, speciality = @speciality, phone = @phone, identity_number = @identity_number WHERE id_mechanic = @id_mechanic"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_mechanic", mechanic.IdMechanic)
                    cmd.Parameters.AddWithValue("@name", mechanic.Name)
                    cmd.Parameters.AddWithValue("@lastname", mechanic.Lastname)
                    cmd.Parameters.AddWithValue("@speciality", mechanic.Speciality)
                    cmd.Parameters.AddWithValue("@phone", mechanic.Phone)
                    cmd.Parameters.AddWithValue("@identity_number", mechanic.IdentityNumber)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al actualizar el mecánico: " & ex.Message)
        End Try
    End Function
End Class