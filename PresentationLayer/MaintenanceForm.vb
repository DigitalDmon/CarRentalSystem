Imports System.Data.SqlClient

Public Class MaintenanceForm

    Private maintenanceManager As New MaintenanceManager()
    Private vehicleManager As New VehicleManager()
    Private mechanicManager As New MechanicManager()

    Private Sub MaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVehicleComboBox()
        LoadMechanicComboBox()
        LoadMaintenances()
    End Sub

    ' Cargar todos los mantenimientos en el DataGridView
    Private Sub LoadMaintenances()
        Try
            ' Obtener todos los mantenimientos
            Dim maintenances As List(Of Maintenance) = maintenanceManager.GetAllMaintenances()

            ' Asignar los mantenimientos al DataGridView
            DgvInfMaintenance.DataSource = maintenances
        Catch ex As Exception
            MessageBox.Show("Error al cargar los mantenimientos: " & ex.Message)
        End Try
    End Sub

    ' Cargar ComboBox de vehículos con placas
    Private Sub LoadVehicleComboBox()
        Try
            Dim query As String = "SELECT DISTINCT id_vehicle, plate FROM vehicles"
            Using conn As SqlConnection = New DatabaseConnection().GetConnection()
                conn.Open()
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                CmbVehPlate.DataSource = table
                CmbVehPlate.DisplayMember = "plate" ' Mostrar la marca
                CmbVehPlate.ValueMember = "id_vehicle" ' Usar la marca como valor interno
                CmbVehPlate.SelectedIndex = -1 ' Opcional: Evitar que haya un valor preseleccionado
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar marcas de vehículos: " & ex.Message)
        End Try
    End Sub

    ' Cargar ComboBox de mecánicos con cédulas
    Private Sub LoadMechanicComboBox()
        Try
            ' Consulta para obtener los id_customer y identity_number
            Dim query As String = "SELECT id_mechanic, identity_number FROM mechanics"
            Using conn As SqlConnection = New DatabaseConnection().GetConnection()
                conn.Open()
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Establecer los datos del ComboBox CmbCustomers (ID del cliente)
                CmbIdentityMechanic.DataSource = table
                CmbIdentityMechanic.DisplayMember = "identity_number" ' Mostrar el ID del cliente
                CmbIdentityMechanic.ValueMember = "id_mechanic" ' Usar el id_customer como valor interno
                CmbIdentityMechanic.SelectedIndex = -1 ' Opcional: Evitar que haya un valor preseleccionado
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegMaintenance_Click(sender As Object, e As EventArgs) Handles BtnRegMaintenance.Click
        Try
            ' Crear el objeto de mantenimiento con los valores de los controles
            Dim maintenance As New Maintenance() With {
                .IdVehicle = Convert.ToInt32(CmbVehPlate.SelectedValue),
                .IdMechanic = Convert.ToInt32(CmbIdentityMechanic.SelectedValue),
                .MaintenanceDate = DateTime.Now, ' Obtener la fecha actual
                .Description = TxtDescriptionMaintenance.Text,
                .Cost = NudCost.Value
            }

            ' Registrar mantenimiento
            maintenanceManager.RegisterMaintenance(maintenance)
            MessageBox.Show("Mantenimiento registrado con éxito.")
        Catch ex As Exception
            MessageBox.Show("Error al registrar mantenimiento: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdMaintenance_Click(sender As Object, e As EventArgs) Handles BtnUpdMaintenance.Click
        Try
            If DgvInfMaintenance.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un mantenimiento para actualizar.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = DgvInfMaintenance.SelectedRows(0)
            Dim maintenanceId As Integer = Convert.ToInt32(selectedRow.Cells("IdMaintenance").Value)

            ' Crear el objeto de mantenimiento con los valores de los controles
            Dim maintenance As New Maintenance() With {
                .IdMaintenance = maintenanceId,
                .IdVehicle = Convert.ToInt32(CmbVehPlate.SelectedValue),
                .IdMechanic = Convert.ToInt32(CmbIdentityMechanic.SelectedValue),
                .Description = TxtDescriptionMaintenance.Text,
                .Cost = NudCost.Value
            }

            ' Actualizar mantenimiento
            If maintenanceManager.UpdateMaintenance(maintenance) Then
                MessageBox.Show("Reserva actualizada exitosamente.")
                LoadMaintenances()
            Else
                MessageBox.Show("Error al actualizar la reserva.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvInfMaintenance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfMaintenance.CellClick
        Try
            ' Verificar que la fila seleccionada es válida
            If e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DgvInfMaintenance.Rows(e.RowIndex)

                ' Obtener los valores de la fila seleccionada
                Dim idMaintenance As Integer = Convert.ToInt32(selectedRow.Cells("IdMaintenance").Value)
                Dim idVehicle As Integer = Convert.ToInt32(selectedRow.Cells("IdVehicle").Value)
                Dim idMechanic As Integer = Convert.ToInt32(selectedRow.Cells("IdMechanic").Value)
                Dim maintenanceDate As DateTime = Convert.ToDateTime(selectedRow.Cells("MaintenanceDate").Value)
                Dim description As String = selectedRow.Cells("Description").Value.ToString()
                Dim cost As Decimal = Convert.ToDecimal(selectedRow.Cells("Cost").Value)

                ' Autorrellenar los controles con los datos de la fila seleccionada

                ' Asignar el valor al ComboBox de vehículos (placas)
                CmbVehPlate.SelectedValue = idVehicle

                ' Asignar el valor al ComboBox de mecánicos (cédulas)
                CmbIdentityMechanic.SelectedValue = idMechanic

                ' Asignar el valor al NumericUpDown para el costo
                NudCost.Value = cost

                ' Asignar la descripción al TextBox
                TxtDescriptionMaintenance.Text = description
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar la fila: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        ' Limpiar ComboBox de vehículos (placas)
        CmbVehPlate.SelectedIndex = -1  ' Resetea la selección (sin selección)

        ' Limpiar ComboBox de mecánicos (cédulas)
        CmbIdentityMechanic.SelectedIndex = -1  ' Resetea la selección (sin selección)

        ' Limpiar NumericUpDown (costo)
        NudCost.Value = 0  ' Restablece el valor a 0

        ' Limpiar TextBox (descripción)
        TxtDescriptionMaintenance.Clear()  ' Limpia el texto

        ' Si tienes otros controles adicionales, puedes limpiarlos de la misma manera
    End Sub

    Private Sub BtnToMainMenu_Click(sender As Object, e As EventArgs) Handles BtnToMainMenu.Click
        Try
            ' Muestra el formulario principal existente
            Me.Hide()
            MainForm.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al regresar al menú principal: " & ex.Message)
        End Try
    End Sub


End Class