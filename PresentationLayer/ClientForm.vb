Imports System.Data

Public Class ClientForm

    Private clientManager As New ClientManager()

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadClientData()

    End Sub

    ' Botón para registrar un nuevo cliente
    Private Sub LoadClientData()

        ' Intentar obtener los clientes
        Try
            ' Obtener los clientes
            Dim dataSet As DataSet = clientManager.GetClients()
            ' Asignar el DataSet al DataGridView
            DgvInfClients.DataSource = dataSet.Tables("customers")
        Catch ex As Exception
            MessageBox.Show("Error while showing clients" & ex.Message)
        End Try

    End Sub

    Private Sub BtnRegClient_Click(sender As Object, e As EventArgs) Handles BtnRegClient.Click

        ' Intentar registrar un nuevo cliente
        Try
            ' Obtener datos un nuevo cliente
            Dim name As String = TxtName.Text
            Dim lastname As String = TxtLastName.Text
            Dim identity_number As String = TxtIdeNumber.Text
            Dim phone_number As String = TxtPhoNumber.Text
            Dim email As String = TxtEmail.Text

            If clientManager.RegisterClient(name, lastname, identity_number, phone_number, email) Then

                ' Mostrar un mensaje de éxito
                MessageBox.Show("Client registered successfully.")
                ' Actualizar los datos de los clientes
                LoadClientData()

            End If

        Catch ex As Exception

            ' Mostrar un mensaje de error si ocurre un error
            MessageBox.Show("Error while trying to register a client: " & ex.Message)

        End Try

    End Sub

    Private Sub BtnCleanInputs_Click(sender As Object, e As EventArgs) Handles BtnCleanInputs.Click

        ' Limpia los campos de entrada
        TxtName.Text = String.Empty
        TxtLastName.Text = String.Empty
        TxtIdeNumber.Text = String.Empty
        TxtPhoNumber.Text = String.Empty
        TxtEmail.Text = String.Empty

        ' Opcional: Coloca el foco en el primer campo
        TxtName.Focus()

    End Sub

    Private Sub BtnToMainMenu_Click(sender As Object, e As EventArgs) Handles BtnToMainMenu.Click

        ' Mostrar el formulario principal que ya está oculto
        MainForm.Show()

        ' Cerrar el formulario actual
        Me.Close()

    End Sub

    Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click

        ' Verificar si hay una fila seleccionada
        If DgvInfClients.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a client to delete.")
            Return
        End If

        ' Obtener el ID del cliente seleccionado
        Dim selectedRow As DataGridViewRow = DgvInfClients.SelectedRows(0)
        Dim clientId As Integer = Convert.ToInt32(selectedRow.Cells("id_customer").Value) ' Suponiendo que la columna se llama 'id'

        ' Confirmar eliminación
        Dim confirm = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Try
                ' Llamar al método para eliminar el cliente
                If clientManager.DeleteClient(clientId) Then
                    MessageBox.Show("Client deleted successfully.")
                    LoadClientData() ' Recargar los datos
                End If
            Catch ex As Exception
                MessageBox.Show("Error while deleting the client: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub BtnUpdateClient_Click(sender As Object, e As EventArgs) Handles BtnUpdateClient.Click

        ' Verificar si hay una fila seleccionada
        If DgvInfClients.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a client to update.")
            Return
        End If

        ' Obtener el ID del cliente seleccionado
        Dim selectedRow As DataGridViewRow = DgvInfClients.SelectedRows(0)
        Dim clientId As Integer = Convert.ToInt32(selectedRow.Cells("id_customer").Value)

        ' Obtener los datos editados
        Dim name As String = TxtName.Text
        Dim lastname As String = TxtLastName.Text
        Dim identity_number As String = TxtIdeNumber.Text
        Dim phone_number As String = TxtPhoNumber.Text
        Dim email As String = TxtEmail.Text

        ' Intentar actualizar
        Try
            If clientManager.UpdateClient(clientId, name, lastname, identity_number, phone_number, email) Then
                MessageBox.Show("Client updated successfully.")
                LoadClientData() ' Recargar los datos
            End If
        Catch ex As Exception
            MessageBox.Show("Error while updating the client: " & ex.Message)
        End Try

    End Sub

    Private Sub DgvInfClients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInfClients.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DgvInfClients.Rows(e.RowIndex)
            TxtName.Text = selectedRow.Cells("name").Value.ToString()
            TxtLastName.Text = selectedRow.Cells("lastname").Value.ToString()
            TxtIdeNumber.Text = selectedRow.Cells("identity_number").Value.ToString()
            TxtPhoNumber.Text = selectedRow.Cells("phone_number").Value.ToString()
            TxtEmail.Text = selectedRow.Cells("email").Value.ToString()
        End If
    End Sub


End Class