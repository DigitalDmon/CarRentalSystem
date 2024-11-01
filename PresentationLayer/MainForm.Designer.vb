<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnRegClient = New Button()
        BtnRegVechicle = New Button()
        BtnRegPayment = New Button()
        BtnRegReservation = New Button()
        BtnRegMaintenance = New Button()
        BtnRegMechanic = New Button()
        SuspendLayout()
        ' 
        ' BtnRegClient
        ' 
        BtnRegClient.Anchor = AnchorStyles.Top
        BtnRegClient.AutoSize = True
        BtnRegClient.Font = New Font("Segoe UI", 12F)
        BtnRegClient.Location = New Point(304, 97)
        BtnRegClient.Name = "BtnRegClient"
        BtnRegClient.Size = New Size(193, 31)
        BtnRegClient.TabIndex = 0
        BtnRegClient.Text = "Registrar cliente"
        BtnRegClient.UseVisualStyleBackColor = True
        ' 
        ' BtnRegVechicle
        ' 
        BtnRegVechicle.Anchor = AnchorStyles.Top
        BtnRegVechicle.AutoSize = True
        BtnRegVechicle.Font = New Font("Segoe UI", 12F)
        BtnRegVechicle.Location = New Point(304, 142)
        BtnRegVechicle.Name = "BtnRegVechicle"
        BtnRegVechicle.Size = New Size(193, 31)
        BtnRegVechicle.TabIndex = 1
        BtnRegVechicle.Text = "Registrar vehículo"
        BtnRegVechicle.UseVisualStyleBackColor = True
        ' 
        ' BtnRegPayment
        ' 
        BtnRegPayment.Anchor = AnchorStyles.Top
        BtnRegPayment.AutoSize = True
        BtnRegPayment.Font = New Font("Segoe UI", 12F)
        BtnRegPayment.Location = New Point(304, 187)
        BtnRegPayment.Name = "BtnRegPayment"
        BtnRegPayment.Size = New Size(193, 31)
        BtnRegPayment.TabIndex = 2
        BtnRegPayment.Text = "Registrar pago"
        BtnRegPayment.UseVisualStyleBackColor = True
        ' 
        ' BtnRegReservation
        ' 
        BtnRegReservation.Anchor = AnchorStyles.Top
        BtnRegReservation.AutoSize = True
        BtnRegReservation.Font = New Font("Segoe UI", 12F)
        BtnRegReservation.Location = New Point(304, 232)
        BtnRegReservation.Name = "BtnRegReservation"
        BtnRegReservation.Size = New Size(193, 31)
        BtnRegReservation.TabIndex = 3
        BtnRegReservation.Text = "Registrar reserva"
        BtnRegReservation.UseVisualStyleBackColor = True
        ' 
        ' BtnRegMaintenance
        ' 
        BtnRegMaintenance.Anchor = AnchorStyles.Top
        BtnRegMaintenance.AutoSize = True
        BtnRegMaintenance.Font = New Font("Segoe UI", 12F)
        BtnRegMaintenance.Location = New Point(304, 277)
        BtnRegMaintenance.Name = "BtnRegMaintenance"
        BtnRegMaintenance.Size = New Size(193, 31)
        BtnRegMaintenance.TabIndex = 4
        BtnRegMaintenance.Text = "Registrar mantenimiento"
        BtnRegMaintenance.UseVisualStyleBackColor = True
        ' 
        ' BtnRegMechanic
        ' 
        BtnRegMechanic.Anchor = AnchorStyles.Top
        BtnRegMechanic.AutoSize = True
        BtnRegMechanic.Font = New Font("Segoe UI", 12F)
        BtnRegMechanic.Location = New Point(304, 322)
        BtnRegMechanic.Name = "BtnRegMechanic"
        BtnRegMechanic.Size = New Size(193, 31)
        BtnRegMechanic.TabIndex = 5
        BtnRegMechanic.Text = "Registrar mecánico"
        BtnRegMechanic.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnRegMechanic)
        Controls.Add(BtnRegMaintenance)
        Controls.Add(BtnRegReservation)
        Controls.Add(BtnRegPayment)
        Controls.Add(BtnRegVechicle)
        Controls.Add(BtnRegClient)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnRegClient As Button
    Friend WithEvents BtnRegVechicle As Button
    Friend WithEvents BtnRegPayment As Button
    Friend WithEvents BtnRegReservation As Button
    Friend WithEvents BtnRegMaintenance As Button
    Friend WithEvents BtnRegMechanic As Button
End Class
