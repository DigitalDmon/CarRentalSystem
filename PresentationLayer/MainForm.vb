Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Aquí puedes inicializar cosas específicas del formulario principal si es necesario

    End Sub

    Private Sub BtnRegReservation_Click(sender As Object, e As EventArgs) Handles BtnRegReservation.Click

        ' Crear una nueva instancia del formulario de registro de reservaciones
        Dim bookingForm As New BookingForm()

        ' Ocultar el formulario principal
        Me.Hide()

        ' Mostrar el formulario de registro de cliente de forma modal
        bookingForm.ShowDialog()

        ' Reaparecer el formulario principal cuando el formulario de cliente se cierre
        Me.Show()

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

    Private Sub BtnRegMaintenance_Click(sender As Object, e As EventArgs) Handles BtnRegMaintenance.Click

        ' Crear una nueva instancia del formulario de registro de mantenimientos
        Dim maintenanceForm As New MaintenanceForm()

        ' Ocultar el formulario principal
        Me.Hide()

        ' Mostrar el formulario de registro de cliente de forma modal
        maintenanceForm.ShowDialog()

        ' Reaparecer el formulario principal cuando el formulario de cliente se cierre
        Me.Show()

    End Sub

    Private Sub BtnRegMechanic_Click(sender As Object, e As EventArgs) Handles BtnRegMechanic.Click

        ' Crear una nueva instancia del formulario de registro de mecánicos
        Dim mechanicForm As New MechanicForm()

        ' Ocultar el formulario principal
        Me.Hide()

        ' Mostrar el formulario de registro de cliente de forma modal
        mechanicForm.ShowDialog()

        ' Reaparecer el formulario principal cuando el formulario de cliente se cierre
        Me.Show()

    End Sub

    Private Sub BtnRegPayment_Click(sender As Object, e As EventArgs) Handles BtnRegPayment.Click

        ' Crear una nueva instancia del formulario de registro de pagos
        Dim paymentForm As New PaymentForm()

        ' Ocultar el formulario principal
        Me.Hide()

        ' Mostrar el formulario de registro de cliente de forma modal
        paymentForm.ShowDialog()

        ' Reaparecer el formulario principal cuando el formulario de cliente se cierre
        Me.Show()

    End Sub

    Private Sub BtnRegVechicle_Click(sender As Object, e As EventArgs) Handles BtnRegVechicle.Click

        ' Crear una nueva instancia del formulario de registro de vehículos
        Dim vehicleForm As New VehicleForm()

        ' Ocultar el formulario principal
        Me.Hide()

        ' Mostrar el formulario de registro de cliente de forma modal
        vehicleForm.ShowDialog()

        ' Reaparecer el formulario principal cuando el formulario de cliente se cierre
        Me.Show()

    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click

        ' Finaliza la aplicación cerrando todos los formularios abiertos
        Application.Exit()

    End Sub

End Class
