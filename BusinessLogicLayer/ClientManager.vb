Public Class ClientManager
    Private ReadOnly clientRepository As New ClientRepository()

    Public Function GetAllCustomers() As List(Of Customer)
        Return clientRepository.GetAll()
    End Function

    Public Function RegisterCustomer(customer As Customer) As Boolean
        If String.IsNullOrEmpty(customer.Name) Then
            Throw New Exception("El nombre del cliente es obligatorio.")
        End If
        Return clientRepository.Insert(customer)
    End Function

    Public Function DeleteCustomer(customerId As Integer) As Boolean
        If customerId <= 0 Then
            Throw New Exception("ID del cliente inválido.")
        End If
        Return clientRepository.Delete(customerId)
    End Function

    Public Function UpdateCustomer(customer As Customer) As Boolean
        If String.IsNullOrEmpty(customer.Name) OrElse String.IsNullOrEmpty(customer.Lastname) Then
            Throw New Exception("El nombre y apellido son obligatorios.")
        End If
        Return clientRepository.Update(customer)
    End Function



End Class
