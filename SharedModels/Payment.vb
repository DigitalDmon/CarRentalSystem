' Modelo para la tabla "payments"
Public Class Payment
    Public Property IdPayment As Integer
    Public Property IdBooking As Integer
    Public Property Amount As Decimal
    Public Property PaymentMethod As String
    Public Property PaymentDate As DateTime
End Class