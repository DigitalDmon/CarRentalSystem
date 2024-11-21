Public Class VehicleForm

    Private vehicleManager As New VehicleManager()

    Private Sub VehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVehicleData()
    End Sub

    Private Sub LoadVehicleData()
        Try
            ' Cargar los datos de los vehículos en el DataGridView
            Dim dataSet As DataSet = vehicleManager.GetVehicles()
            DgvInfVehicles.DataSource = dataSet.Tables("vehicles")
        Catch ex As Exception
            MessageBox.Show("Error loading vehicle data: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvInfVehicles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfVehicles.CellContentClick

    End Sub

    Private Sub BtnRegVehicle_Click(sender As Object, e As EventArgs) Handles BtnRegVehicle.Click
        Try
            ' Obtener los datos del formulario
            Dim brand As String = TxtBrand.Text
            Dim model As String = TxtModel.Text
            Dim year As Integer = CInt(TxtYear.Text)
            Dim plate As String = TxtPlate.Text
            Dim fuel As String = TxtFuel.Text

            ' Registrar el vehículo
            If vehicleManager.RegisterVehicle(brand, model, year, plate, fuel) Then
                MessageBox.Show("Vehicle registered successfully.")
                LoadVehicleData() ' Actualizar el DataGridView
            End If
        Catch ex As Exception
            MessageBox.Show("Error registering vehicle: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDeleteVehicle_Click(sender As Object, e As EventArgs) Handles BtnDeleteVehicle.Click
        Try
            ' Obtener el ID del vehículo seleccionado
            Dim id_vehicle As Integer = CInt(DgvInfVehicles.CurrentRow.Cells("id_vehicle").Value)

            ' Confirmar antes de eliminar
            If MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                If vehicleManager.DeleteVehicle(id_vehicle) Then
                    MessageBox.Show("Vehicle deleted successfully.")
                    LoadVehicleData()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting vehicle: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdateVehicle_Click(sender As Object, e As EventArgs) Handles BtnUpdateVehicle.Click

        ' Verificar si hay una fila seleccionada
        If DgvInfVehicles.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a vehicle to update.")
            Return
        End If

        Try
            ' Obtener el ID del vehículo seleccionado en el DataGridView
            Dim id_vehicle As Integer = CInt(DgvInfVehicles.CurrentRow.Cells("id_vehicle").Value)
            Dim brand As String = TxtBrand.Text
            Dim model As String = TxtModel.Text
            Dim year As Integer = CInt(TxtYear.Text)
            Dim plate As String = TxtPlate.Text
            Dim fuel As String = TxtFuel.Text

            ' Actualizar el vehículo
            If vehicleManager.UpdateVehicle(id_vehicle, brand, model, year, plate, fuel) Then
                MessageBox.Show("Vehicle updated successfully.")
                LoadVehicleData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating vehicle: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvInfVehicles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfVehicles.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DgvInfVehicles.Rows(e.RowIndex)
            TxtBrand.Text = selectedRow.Cells("brand").Value.ToString()
            TxtModel.Text = selectedRow.Cells("model").Value.ToString()
            TxtYear.Text = selectedRow.Cells("year").Value.ToString()
            TxtPlate.Text = selectedRow.Cells("plate").Value.ToString()
            TxtFuel.Text = selectedRow.Cells("fuel").Value.ToString()
        End If
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        TxtBrand.Text = String.Empty
        TxtModel.Text = String.Empty
        TxtYear.Text = String.Empty
        TxtPlate.Text = String.Empty
        TxtFuel.Text = String.Empty
        TxtBrand.Focus()
    End Sub

    Private Sub BtnToMainMenu_Click(sender As Object, e As EventArgs) Handles BtnToMainMenu.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class