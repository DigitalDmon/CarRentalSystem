Public Class MechanicForm

    Private mechanicManager As New MechanicManager()

    Private Sub MechanicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMechanicData()
    End Sub

    Private Sub LoadMechanicData()
        Try
            Dim mechanics As List(Of Mechanic) = mechanicManager.GetAllMechanics()
            DgvInfMechanics.DataSource = mechanics
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos de mecánicos: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegMechanic_Click(sender As Object, e As EventArgs) Handles BtnRegMechanic.Click
        Try
            Dim mechanic As New Mechanic With {
                .Name = TxtName.Text,
                .Lastname = TxtLastname.Text,
                .Speciality = TxtSpeciality.Text,
                .Phone = TxtPhone.Text,
                .IdentityNumber = TxtIdentity.Text
            }

            If mechanicManager.RegisterMechanic(mechanic) Then
                MessageBox.Show("Mecánico registrado exitosamente.")
                LoadMechanicData()
            Else
                MessageBox.Show("Error al registrar el mecánico.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdMechanic_Click(sender As Object, e As EventArgs) Handles BtnUpdMechanic.Click
        Try
            If DgvInfMechanics.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un mecánico para actualizar.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = DgvInfMechanics.SelectedRows(0)
            Dim mechanic As New Mechanic With {
                .IdMechanic = Convert.ToInt32(selectedRow.Cells("IdMechanic").Value),
                .Name = TxtName.Text,
                .Lastname = TxtLastname.Text,
                .Speciality = TxtSpeciality.Text,
                .Phone = TxtPhone.Text,
                .IdentityNumber = TxtIdentity.Text
            }

            If mechanicManager.UpdateMechanic(mechanic) Then
                MessageBox.Show("Mecánico actualizado exitosamente.")
                LoadMechanicData()
            Else
                MessageBox.Show("Error al actualizar el mecánico.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvInfMechanics_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfMechanics.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DgvInfMechanics.Rows(e.RowIndex)
                TxtName.Text = selectedRow.Cells("Name").Value?.ToString()
                TxtLastname.Text = selectedRow.Cells("Lastname").Value?.ToString()
                TxtSpeciality.Text = selectedRow.Cells("Speciality").Value?.ToString()
                TxtPhone.Text = selectedRow.Cells("Phone").Value?.ToString()
                TxtIdentity.Text = selectedRow.Cells("IdentityNumber").Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar un mecánico: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        TxtName.Clear()
        TxtLastname.Clear()
        TxtSpeciality.Clear()
        TxtPhone.Clear()
        TxtIdentity.Clear()
    End Sub

    Private Sub BtnBackToMenu_Click(sender As Object, e As EventArgs) Handles BtnBackToMenu.Click
        Try
            ' Muestra el formulario principal existente
            Me.Hide()
            MainForm.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al regresar al menú principal: " & ex.Message)
        End Try
    End Sub
End Class