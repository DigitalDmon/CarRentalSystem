Public Class PaymentForm

    Private paymentManager As New PaymentManager()
    Private bookingManager As New BookingManager()

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los pagos en el DataGridView
        LoadPayments()
        ' Cargar los métodos de pago en el ComboBox
        LoadPaymentMethods()
        ' Cargar las reservaciones en el ComboBox
        LoadBookings()
    End Sub

    ' Cargar los pagos en el DataGridView
    Private Sub LoadPayments()
        Try
            Dim payments As List(Of Payment) = paymentManager.GetPayments()
            DgvInfPayments.DataSource = payments
        Catch ex As Exception
            MessageBox.Show("Error loading payments: " & ex.Message)
        End Try
    End Sub

    ' Cargar los métodos de pago en el ComboBox
    Private Sub LoadPaymentMethods()
        Dim paymentMethods As New List(Of String) From {
            "Credit Card",
            "Cash",
            "Bank Transfer"
        }
        CmbPayMethod.DataSource = paymentMethods
    End Sub

    ' Método para cargar las reservaciones en el ComboBox
    Private Sub LoadBookings()
        Try
            Dim bookingManager As New BookingManager()
            Dim bookings As List(Of Booking) = bookingManager.GetAllBookings()
            CmbBooking.DataSource = bookings
            CmbBooking.DisplayMember = "IdBooking"
            CmbBooking.ValueMember = "IdBooking"
        Catch ex As Exception
            MessageBox.Show("Error loading bookings: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegPayment_Click(sender As Object, e As EventArgs) Handles BtnRegPayment.Click
        Try
            Dim payment As New Payment With {
                .IdBooking = Convert.ToInt32(CmbBooking.SelectedValue),
                .Amount = NudAmount.Value,
                .PaymentMethod = CmbPayMethod.SelectedItem.ToString(),
                .PaymentDate = DateTime.Now ' La fecha se toma automáticamente
            }

            If paymentManager.RegisterPayment(payment) Then
                MessageBox.Show("Payment registered successfully.")
                LoadPayments() ' Actualizar el DataGridView
            Else
                MessageBox.Show("Error registering payment.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        CmbBooking.SelectedIndex = -1
        CmbPayMethod.SelectedIndex = -1

        NudAmount.Value = 0
    End Sub

    Private Sub BtnBackToMenu_Click(sender As Object, e As EventArgs) Handles BtnBackToMenu.Click
        Try
            Me.Hide()
            MainForm.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al regresar al menú principal: " & ex.Message)
        End Try
    End Sub
End Class