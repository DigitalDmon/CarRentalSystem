Imports System.Data

Public Class ClientManager

    ' Repositorio de clientes
    Private ReadOnly clientRepository As New ClientRepository()

    ' Método para obtener todos los clientes (Para mostrar en la UI)
    Public Function GetClients() As DataSet

        ' Intentar obtener todos los clientes
        Try
            ' Retornar todos los clientes
            Return clientRepository.GetAllClients()
        Catch ex As Exception

            ' Lanzar una excepción si ocurre un error
            Throw New ApplicationException("Error while trying to optain clients.", ex)

        End Try

    End Function

    ' Método para enviar los datos un nuevo cliente
    Public Function RegisterClient(name As String, lastname As String, identity_number As String, phone_number As String, email As String)

        ' Verificar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(name) OrElse
            String.IsNullOrWhiteSpace(lastname) OrElse
            String.IsNullOrWhiteSpace(identity_number) OrElse
            String.IsNullOrWhiteSpace(phone_number) OrElse
            String.IsNullOrWhiteSpace(email) Then

            ' Lanzar una excepción si los campos están vacíos
            Throw New ArgumentException("Client fields can not be in blank spaces.")

        End If

        ' Intentar registrar un nuevo cliente
        Try
            ' Registrar un nuevo cliente
            clientRepository.RegisterClient(name, lastname, identity_number, phone_number, email)
            ' Retornar verdadero si el cliente se registró correctamente
            Return True
        Catch ex As Exception
            ' Lanzar una excepción si ocurre un error
            Throw New ApplicationException("Error trying to insert a client.", ex)
        End Try

    End Function

    Public Function DeleteClient(clientId As Integer) As Boolean
        Try
            clientRepository.DeleteClient(clientId)
            Return True
        Catch ex As Exception
            Throw New ApplicationException("Error while deleting the client.", ex)
        End Try
    End Function

    Public Function UpdateClient(clientId As Integer, name As String, lastname As String, identity_number As String, phone_number As String, email As String) As Boolean
        Try
            clientRepository.UpdateClient(clientId, name, lastname, identity_number, phone_number, email)
            Return True
        Catch ex As Exception
            Throw New ApplicationException("Error while updating the client.", ex)
        End Try
    End Function


End Class