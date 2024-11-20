Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Aquí puedes inicializar cosas específicas del formulario principal si es necesario

    End Sub

    Private Sub BtnRegClient_Click(sender As Object, e As EventArgs) Handles BtnRegClient.Click

        ' Crear una nueva instancia del formulario de registro de clientes
        Dim clientForm As New ClientForm()

        ' Ocultar el formulario principal
        Me.Hide()

        ' Mostrar el formulario de registro de cliente de forma modal
        clientForm.ShowDialog()

        ' Reaparecer el formulario principal cuando el formulario de cliente se cierre
        Me.Show()

    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click

        ' Finaliza la aplicación cerrando todos los formularios abiertos
        Application.Exit()

    End Sub

End Class
