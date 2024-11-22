Public Class BookingForm

    Private bookingManager As New BookingManager()
    Private customerManager As New ClientManager()
    Private vehicleManager As New VehicleManager()

    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        LoadVehicles()
    End Sub

    Private Sub LoadCustomers()
        Try
            Dim customers = customerManager.GetCustomersForComboBox()
            CbCustomersBooking.DataSource = customers
            CbCustomersBooking.DisplayMember = "name"
            CbCustomersBooking.ValueMember = "id_customer"

            CbCusIdentityBooking.DataSource = customers
            CbCusIdentityBooking.DisplayMember = "identity_number"
            CbCusIdentityBooking.ValueMember = "id_customer"
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVehicles()
        Try
            Dim brands = vehicleManager.GetVehicleBrands()
            CbVehBrandBooking.DataSource = brands
            CbVehBrandBooking.DisplayMember = "brand"
            CbVehBrandBooking.ValueMember = "brand"

            CbVehModelBooking.DataSource = Nothing
            CbVehModelBooking.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error loading vehicles: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadBookingData()
        Try
            Dim dataSet As DataSet = bookingManager.GetBookings()
            DgvInfBooking.DataSource = dataSet.Tables("bookings")
        Catch ex As Exception
            MessageBox.Show("Error loading booking data: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub CbVehBrandBooking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVehBrandBooking.SelectedIndexChanged
        Try
            Dim selectedBrand = CbVehBrandBooking.SelectedValue.ToString()
            Dim models = vehicleManager.GetModelsByBrand(selectedBrand)
            CbVehModelBooking.DataSource = models
            CbVehModelBooking.DisplayMember = "model"
            CbVehModelBooking.ValueMember = "id_vehicle"
            CbVehModelBooking.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error loading models: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegBooking_Click(sender As Object, e As EventArgs) Handles BtnRegBooking.Click
        Try
            Dim idCustomer As Integer = CInt(CbCustomersBooking.SelectedValue)
            Dim idVehicle As Integer = CInt(CbVehModelBooking.SelectedValue)
            Dim dateStart As Date = DtpStart.Value
            Dim dateEnd As Date = DtpEnd.Value

            If bookingManager.RegisterBooking(idCustomer, idVehicle, dateStart, dateEnd) Then
                MessageBox.Show("Booking registered successfully.")
                LoadBookingData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error registering booking: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdBooking_Click(sender As Object, e As EventArgs) Handles BtnUpdBooking.Click
        'Try
        '    ' Verificar si hay una fila seleccionada
        '    If DgvInfBooking.SelectedRows.Count = 0 Then
        '        MessageBox.Show("Please select a booking to update.")
        '        Return
        '    End If

        '    ' Obtener datos del formulario
        '    Dim idBooking As Integer = CInt(DgvInfBooking.CurrentRow.Cells("id_booking").Value)
        '    Dim idCustomer As Integer = CInt(CbCustomersBooking.SelectedValue)
        '    Dim idVehicle As Integer = CInt(CbVehModelBooking.SelectedValue)
        '    Dim dateStart As Date = DtpStart.Value
        '    Dim dateEnd As Date = DtpEnd.Value

        '    ' Actualizar la reserva
        '    If bookingManager.UpdateBooking(idBooking, idCustomer, idVehicle, dateStart, dateEnd) Then
        '        MessageBox.Show("Booking updated successfully.")
        '        LoadBookingData()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error updating booking: " & ex.Message)
        'End Try
    End Sub

    Private Sub BtnDelBooking_Click(sender As Object, e As EventArgs) Handles BtnDelBooking.Click
        'Try
        '    ' Verificar si hay una fila seleccionada
        '    If DgvInfBookings.SelectedRows.Count = 0 Then
        '        MessageBox.Show("Please select a booking to delete.")
        '        Return
        '    End If

        '    ' Obtener ID de la reserva seleccionada
        '    Dim idBooking As Integer = CInt(DgvInfBookings.CurrentRow.Cells("id_booking").Value)

        '    ' Confirmar eliminación
        '    If MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
        '        If bookingManager.DeleteBooking(idBooking) Then
        '            MessageBox.Show("Booking deleted successfully.")
        '            LoadBookingData()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error deleting booking: " & ex.Message)
        'End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click

    End Sub

    Private Sub DgvInfBooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfBooking.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DgvInfBooking.Rows(e.RowIndex)
            'TxtStatusBooking.Text = selectedRow.Cells("status").Value.ToString()
            CbCustomersBooking.SelectedValue = selectedRow.Cells("id_customer").Value
            CbVehModelBooking.SelectedValue = selectedRow.Cells("id_vehicle").Value
            'DtpBooking.Value = DateTime.Parse(selectedRow.Cells("date_booking").Value.ToString())
            DtpStart.Value = DateTime.Parse(selectedRow.Cells("date_start").Value.ToString())
            DtpEnd.Value = DateTime.Parse(selectedRow.Cells("date_end").Value.ToString())
        End If
    End Sub

    Private Sub DgvInfBookings_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvInfBooking.CellFormatting
        If DgvInfBooking.Columns(e.ColumnIndex).Name = "status" Then
            If e.Value IsNot Nothing Then
                If CInt(e.Value) = 1 Then
                    e.Value = "Activo"
                    e.FormattingApplied = True
                ElseIf CInt(e.Value) = 0 Then
                    e.Value = "Inactivo"
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub


End Class