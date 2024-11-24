Imports System.Data

Public Class ClientForm

    Private clientManager As New ClientManager()

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    Private Sub LoadCustomerData()
        Try
            Dim customers As List(Of Customer) = clientManager.GetAllCustomers()
            DgvInfClients.DataSource = customers
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegCustomer_Click(sender As Object, e As EventArgs) Handles BtnRegClient.Click
        Try
            Dim customer As New Customer With {
                .Name = TxtName.Text,
                .Lastname = TxtLastName.Text,
                .IdentityNumber = TxtIdeNumber.Text,
                .PhoneNumber = TxtPhoNumber.Text,
                .Email = TxtEmail.Text
            }

            If clientManager.RegisterCustomer(customer) Then
                MessageBox.Show("Customer registered successfully.")
                LoadCustomerData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error registering customer: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click
        Try
            If DgvInfClients.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un cliente para eliminar.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = DgvInfClients.SelectedRows(0)
            Dim customerId As Integer = Convert.ToInt32(selectedRow.Cells("IdCustomer").Value)

            If clientManager.DeleteCustomer(customerId) Then
                MessageBox.Show("Cliente eliminado con éxito.")
                LoadCustomerData()
            Else
                MessageBox.Show("Error al eliminar el cliente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdateClient_Click(sender As Object, e As EventArgs) Handles BtnUpdateClient.Click
        Try
            If DgvInfClients.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un cliente para actualizar.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = DgvInfClients.SelectedRows(0)
            Dim customerId As Integer = Convert.ToInt32(selectedRow.Cells("IdCustomer").Value)

            Dim customer As New Customer With {
                .IdCustomer = customerId,
                .Name = TxtName.Text,
                .Lastname = TxtLastName.Text,
                .IdentityNumber = TxtIdeNumber.Text,
                .PhoneNumber = TxtPhoNumber.Text,
                .Email = TxtEmail.Text
            }

            If clientManager.UpdateCustomer(customer) Then
                MessageBox.Show("Cliente actualizado con éxito.")
                LoadCustomerData()
            Else
                MessageBox.Show("Error al actualizar el cliente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvInfClients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfClients.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DgvInfClients.Rows(e.RowIndex)

                ' Rellenar los campos de texto con los valores de la fila seleccionada
                TxtName.Text = selectedRow.Cells("Name").Value?.ToString()
                TxtLastName.Text = selectedRow.Cells("Lastname").Value?.ToString()
                TxtIdeNumber.Text = selectedRow.Cells("IdentityNumber").Value?.ToString()
                TxtPhoNumber.Text = selectedRow.Cells("PhoneNumber").Value?.ToString()
                TxtEmail.Text = selectedRow.Cells("Email").Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al seleccionar el cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click
        TxtName.Clear()
        TxtLastName.Clear()
        TxtIdeNumber.Clear()
        TxtPhoNumber.Clear()
        TxtEmail.Clear()
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
