Imports System.Data.SqlClient

Public Class BookingForm

    Private bookingManager As New BookingManager()

    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingData()
        LoadCustomerData()
        LoadVehicleData()
    End Sub

    Private Sub LoadBookingData()
        Try
            Dim bookings As List(Of Booking) = bookingManager.GetAllBookings()
            DgvInfBooking.DataSource = bookings
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos de reservas: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCustomerData()
        Try
            ' Consulta para obtener los id_customer y identity_number
            Dim query As String = "SELECT id_customer, name, identity_number FROM customers"
            Using conn As SqlConnection = New DatabaseConnection().GetConnection()
                conn.Open()
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Establecer los datos del ComboBox CmbCustomers (ID del cliente)
                CmbCustomers.DataSource = table
                CmbCustomers.DisplayMember = "name" ' Mostrar el ID del cliente
                CmbCustomers.ValueMember = "id_customer" ' Usar el id_customer como valor interno
                CmbCustomers.SelectedIndex = -1 ' Opcional: Evitar que haya un valor preseleccionado

                ' Establecer los datos del ComboBox CmbIdentity (Cédula del cliente)
                CmbCusIdentity.DataSource = table
                CmbCusIdentity.DisplayMember = "identity_number" ' Mostrar la cédula
                CmbCusIdentity.ValueMember = "id_customer" ' Usar el id_customer como valor interno
                CmbCusIdentity.SelectedIndex = -1 ' Opcional: Evitar que haya un valor preseleccionado
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadVehicleData()
        Try
            Dim query As String = "SELECT DISTINCT id_vehicle, brand FROM vehicles"
            Using conn As SqlConnection = New DatabaseConnection().GetConnection()
                conn.Open()
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                CmbVehBrand.DataSource = table
                CmbVehBrand.DisplayMember = "brand" ' Mostrar la marca
                CmbVehBrand.ValueMember = "id_vehicle" ' Usar la marca como valor interno
                CmbVehBrand.SelectedIndex = -1 ' Opcional: Evitar que haya un valor preseleccionado
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar marcas de vehículos: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVehicleModels()
        Try
            If CmbVehBrand.SelectedIndex = -1 Then
                CmbVehModel.DataSource = Nothing
                Return
            End If

            Dim selectedBrand As String = CmbVehBrand.Text
            Dim query As String = "SELECT id_vehicle, model FROM vehicles WHERE brand = @brand"
            Using conn As SqlConnection = New DatabaseConnection().GetConnection()
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@brand", selectedBrand)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    CmbVehModel.DataSource = table
                    CmbVehModel.DisplayMember = "model" ' Mostrar el modelo
                    CmbVehModel.ValueMember = "id_vehicle" ' Usar el ID como valor interno
                    CmbVehModel.SelectedIndex = -1 ' Opcional: Evitar que haya un valor preseleccionado
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar modelos de vehículos: " & ex.Message)
        End Try
    End Sub

    ' Función para obtener las fechas de inicio y fin basadas en IdBooking
    Private Function GetBookingDates(idBooking As Integer) As (DateTime, DateTime)
        Dim startDate As DateTime
        Dim endDate As DateTime

        ' Conectar a la base de datos y ejecutar la consulta
        Using conn As SqlConnection = New DatabaseConnection().GetConnection()
            Dim query As String = "SELECT date_start, date_end FROM bookings WHERE id_booking = @IdBooking"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdBooking", idBooking)
                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Leer las fechas de la base de datos
                        startDate = Convert.ToDateTime(reader("date_start"))
                        endDate = Convert.ToDateTime(reader("date_end"))
                    Else
                        ' Si no se encuentra la reserva, usar valores por defecto
                        startDate = DateTime.Now
                        endDate = DateTime.Now
                    End If
                End Using
            End Using
        End Using

        ' Devolver las fechas como una tupla
        Return (startDate, endDate)
    End Function

    Private Sub BtnRegBooking_Click(sender As Object, e As EventArgs) Handles BtnRegBooking.Click
        Try
            Dim booking As New Booking With {
                .IdCustomer = Convert.ToInt32(CmbCustomers.SelectedValue),
                .IdVehicle = Convert.ToInt32(CmbVehModel.SelectedValue),
                .DateStart = DtpStart.Value,
                .DateEnd = DtpEnd.Value
            }

            If bookingManager.RegisterBooking(booking) Then
                MessageBox.Show("Reserva registrada exitosamente.")
                LoadBookingData()
            Else
                MessageBox.Show("Error al registrar la reserva.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdBooking_Click(sender As Object, e As EventArgs) Handles BtnUpdBooking.Click
        Try
            If DgvInfBooking.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione una reserva para actualizar.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = DgvInfBooking.SelectedRows(0)
            Dim booking As New Booking With {
                .IdBooking = Convert.ToInt32(selectedRow.Cells("IdBooking").Value),
                .IdCustomer = Convert.ToInt32(CmbCustomers.SelectedValue),
                .IdVehicle = Convert.ToInt32(CmbVehModel.SelectedValue),
                .DateStart = DtpStart.Value,
                .DateEnd = DtpEnd.Value
            }

            If bookingManager.UpdateBooking(booking) Then
                MessageBox.Show("Reserva actualizada exitosamente.")
                LoadBookingData()
            Else
                MessageBox.Show("Error al actualizar la reserva.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        ' Limpiar DateTimePicker (fechas de inicio y fin)
        DtpStart.Value = DateTime.Now
        DtpEnd.Value = DateTime.Now

        ' Limpiar ComboBox de cliente (id_customer) y cédula (identity_number)
        CmbCustomers.SelectedIndex = -1
        CmbCusIdentity.SelectedIndex = -1

        ' Limpiar ComboBox de vehículo (marca y modelo)
        CmbVehBrand.SelectedIndex = -1
        CmbVehModel.SelectedIndex = -1
    End Sub

    Private Sub DgvInfBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfBooking.CellClick
        Try
            If e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DgvInfBooking.Rows(e.RowIndex)

                ' Rellenar los ComboBox con los valores de la fila seleccionada
                CmbCustomers.SelectedValue = selectedRow.Cells("IdCustomer").Value
                CmbCusIdentity.SelectedValue = selectedRow.Cells("IdCustomer").Value ' Cargar la cédula
                CmbVehBrand.SelectedValue = selectedRow.Cells("IdVehicle").Value
                CmbVehModel.SelectedValue = selectedRow.Cells("IdVehicle").Value

                ' Obtener el IdBooking para consultar las fechas
                Dim idBooking As Integer = Convert.ToInt32(selectedRow.Cells("IdBooking").Value)

                ' Obtener las fechas de inicio y fin
                Dim bookingDates = GetBookingDates(idBooking)

                ' Rellenar los DateTimePickers con las fechas obtenidas
                DtpStart.Value = bookingDates.Item1
                DtpEnd.Value = bookingDates.Item2
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar la fila: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        Try
            ' Cerrar el formulario actual y mostrar el formulario principal
            Me.Hide()
            MainForm.Show() ' Asumiendo que el formulario principal se llama MainForm
        Catch ex As Exception
            MessageBox.Show("Error al regresar al menú principal: " & ex.Message)
        End Try
    End Sub

    Private Sub CmbVehBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbVehBrand.SelectedIndexChanged
        LoadVehicleModels()
    End Sub

End Class