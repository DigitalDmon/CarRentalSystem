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

    Private Sub BtnUpdList_Click(sender As Object, e As EventArgs) Handles BtnUpdList.Click

        LoadClientData()

    End Sub

    Private Sub BtnToMainMenu_Click(sender As Object, e As EventArgs) Handles BtnToMainMenu.Click

        ' Mostrar el formulario principal que ya está oculto
        MainForm.Show()

        ' Cerrar el formulario actual
        Me.Close()

    End Sub
End Class