Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Botón para mostrar el formulario de registro de un nuevo cliente
    Private Sub BtnRegClient_Click(sender As Object, e As EventArgs) Handles BtnRegClient.Click

        ' Crear una nueva instancia de ClientForm
        Dim clientForm As New ClientForm()
        ' Mostrar el formulario de registro de un nuevo cliente
        clientForm.ShowDialog()

    End Sub
End Class