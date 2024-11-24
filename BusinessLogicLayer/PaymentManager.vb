Public Class PaymentManager
    Private ReadOnly paymentRepository As New PaymentRepository()

    ' Obtener todos los pagos
    Public Function GetPayments() As List(Of Payment)
        Return paymentRepository.GetAll()
    End Function

    ' Registrar un pago
    Public Function RegisterPayment(payment As Payment) As Boolean
        Return paymentRepository.RegisterPayment(payment)
    End Function
End Class
