Imports System.Data.SqlClient
Imports System.Data

Public Class PaymentRepository

    Private ReadOnly connection As New DatabaseConnection()

    Public Function GetAll() As List(Of Payment)

        Dim payments As New List(Of Payment)()
        Dim query As String = "SELECT * FROM payments"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim payment As New Payment With {
                            .IdPayment = Convert.ToInt32(reader("id_payment")),
                            .IdBooking = Convert.ToInt32(reader("id_booking")),
                            .Amount = Convert.ToDecimal(reader("amount")),
                            .PaymentMethod = reader("payment_method").ToString(),
                            .PaymentDate = Convert.ToDateTime(reader("payment_date"))
                        }
                        payments.Add(payment)
                    End While
                End Using
            End Using
        End Using
        Return payments
    End Function

    ' Función para registrar un nuevo pago
    Public Function RegisterPayment(payment As Payment)

        Dim query As String = "INSERT INTO payments (id_booking, amount, payment_method) VALUES (@IdBooking, @Amount, @PaymentMethod)"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdBooking", payment.IdBooking)
                cmd.Parameters.AddWithValue("@Amount", payment.Amount)
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

End Class
