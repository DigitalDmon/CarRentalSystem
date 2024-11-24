Public Class VehicleForm

    Private vehicleManager As New VehicleManager()

    Private Sub VehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVehicleData()
    End Sub

    Private Sub LoadVehicleData()
        Try
            Dim vehicles As List(Of Vehicle) = vehicleManager.GetAllVehicles()
            DgvInfVehicles.DataSource = vehicles
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos de vehículos: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegVehicle_Click(sender As Object, e As EventArgs) Handles BtnRegVehicle.Click
        Try
            Dim vehicle As New Vehicle With {
                .Brand = TxtBrand.Text,
                .Model = TxtModel.Text,
                .Year = TxtYear.Text,
                .Plate = TxtPlate.Text,
                .Fuel = TxtFuel.Text
            }

            If vehicleManager.RegisterVehicle(vehicle) Then
                MessageBox.Show("Vehículo registrado con éxito.")
                LoadVehicleData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al registrar el vehículo: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdateVehicle_Click(sender As Object, e As EventArgs) Handles BtnUpdateVehicle.Click
        Try
            If DgvInfVehicles.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un vehículo para actualizar.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = DgvInfVehicles.SelectedRows(0)
            Dim vehicleId As Integer = Convert.ToInt32(selectedRow.Cells("IdVehicle").Value)

            Dim vehicle As New Vehicle With {
                .IdVehicle = vehicleId,
                .Brand = TxtBrand.Text,
                .Model = TxtModel.Text,
                .Year = TxtYear.Text,
                .Plate = TxtPlate.Text,
                .Fuel = TxtFuel.Text
            }

            If vehicleManager.UpdateVehicle(vehicle) Then
                MessageBox.Show("Vehículo actualizado con éxito.")
                LoadVehicleData()
            Else
                MessageBox.Show("Error al actualizar el vehículo.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        TxtBrand.Clear()
        TxtModel.Clear()
        TxtYear.Clear()
        TxtPlate.Clear()
        TxtFuel.Clear()
    End Sub

    Private Sub BtnToMainMenu_Click(sender As Object, e As EventArgs) Handles BtnToMainMenu.Click
        Try
            Me.Hide()
            MainForm.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al regresar al menú principal: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvInfVehicles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfVehicles.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DgvInfVehicles.Rows(e.RowIndex)

                TxtBrand.Text = selectedRow.Cells("Brand").Value?.ToString()
                TxtModel.Text = selectedRow.Cells("Model").Value?.ToString()
                TxtYear.Text = selectedRow.Cells("Year").Value?.ToString()
                TxtPlate.Text = selectedRow.Cells("Plate").Value?.ToString()
                TxtFuel.Text = selectedRow.Cells("Fuel").Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al seleccionar el vehículo: " & ex.Message)
        End Try
    End Sub
End Class