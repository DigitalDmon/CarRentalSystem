<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        BtnMainMenu = New Button()
        CbCustomersBooking = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        CbCusIdentityBooking = New ComboBox()
        Label3 = New Label()
        CbVehBrandBooking = New ComboBox()
        Label4 = New Label()
        CbVehModelBooking = New ComboBox()
        Label5 = New Label()
        DtpStart = New DateTimePicker()
        Label6 = New Label()
        DtpEnd = New DateTimePicker()
        BtnRegBooking = New Button()
        BtnUpdBooking = New Button()
        BtnDelBooking = New Button()
        BtnCleanInputs = New Button()
        DgvInfBooking = New DataGridView()
        CType(DgvInfBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnMainMenu
        ' 
        BtnMainMenu.AutoSize = True
        BtnMainMenu.Font = New Font("Segoe UI", 12F)
        BtnMainMenu.Location = New Point(12, 418)
        BtnMainMenu.Name = "BtnMainMenu"
        BtnMainMenu.Size = New Size(156, 31)
        BtnMainMenu.TabIndex = 0
        BtnMainMenu.Text = "Volver al menú"
        BtnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' CbCustomersBooking
        ' 
        CbCustomersBooking.Font = New Font("Segoe UI", 12F)
        CbCustomersBooking.FormattingEnabled = True
        CbCustomersBooking.Location = New Point(12, 33)
        CbCustomersBooking.Name = "CbCustomersBooking"
        CbCustomersBooking.Size = New Size(156, 29)
        CbCustomersBooking.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 21)
        Label1.TabIndex = 3
        Label1.Text = "Nombre del cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(174, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 21)
        Label2.TabIndex = 4
        Label2.Text = "Cédula del cliente:"
        ' 
        ' CbCusIdentityBooking
        ' 
        CbCusIdentityBooking.Font = New Font("Segoe UI", 12F)
        CbCusIdentityBooking.FormattingEnabled = True
        CbCusIdentityBooking.Location = New Point(174, 33)
        CbCusIdentityBooking.Name = "CbCusIdentityBooking"
        CbCusIdentityBooking.Size = New Size(156, 29)
        CbCusIdentityBooking.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(12, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 21)
        Label3.TabIndex = 6
        Label3.Text = "Marca del vehículo:"
        ' 
        ' CbVehBrandBooking
        ' 
        CbVehBrandBooking.Font = New Font("Segoe UI", 12F)
        CbVehBrandBooking.FormattingEnabled = True
        CbVehBrandBooking.Location = New Point(12, 89)
        CbVehBrandBooking.Name = "CbVehBrandBooking"
        CbVehBrandBooking.Size = New Size(156, 29)
        CbVehBrandBooking.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(174, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 21)
        Label4.TabIndex = 8
        Label4.Text = "Modelo del vehículo:"
        ' 
        ' CbVehModelBooking
        ' 
        CbVehModelBooking.Font = New Font("Segoe UI", 12F)
        CbVehModelBooking.FormattingEnabled = True
        CbVehModelBooking.Location = New Point(174, 89)
        CbVehModelBooking.Name = "CbVehModelBooking"
        CbVehModelBooking.Size = New Size(156, 29)
        CbVehModelBooking.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(12, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 21)
        Label5.TabIndex = 10
        Label5.Text = "Fecha de inicio:"
        ' 
        ' DtpStart
        ' 
        DtpStart.Font = New Font("Segoe UI", 12F)
        DtpStart.Location = New Point(12, 145)
        DtpStart.Name = "DtpStart"
        DtpStart.Size = New Size(156, 29)
        DtpStart.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(174, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 21)
        Label6.TabIndex = 12
        Label6.Text = "Fecha de finalización:"
        ' 
        ' DtpEnd
        ' 
        DtpEnd.Font = New Font("Segoe UI", 12F)
        DtpEnd.Location = New Point(174, 145)
        DtpEnd.Name = "DtpEnd"
        DtpEnd.Size = New Size(156, 29)
        DtpEnd.TabIndex = 13
        ' 
        ' BtnRegBooking
        ' 
        BtnRegBooking.AutoSize = True
        BtnRegBooking.Font = New Font("Segoe UI", 12F)
        BtnRegBooking.Location = New Point(12, 180)
        BtnRegBooking.Name = "BtnRegBooking"
        BtnRegBooking.Size = New Size(156, 31)
        BtnRegBooking.TabIndex = 14
        BtnRegBooking.Text = "Registrar reserva"
        BtnRegBooking.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdBooking
        ' 
        BtnUpdBooking.AutoSize = True
        BtnUpdBooking.Font = New Font("Segoe UI", 12F)
        BtnUpdBooking.Location = New Point(174, 180)
        BtnUpdBooking.Name = "BtnUpdBooking"
        BtnUpdBooking.Size = New Size(156, 31)
        BtnUpdBooking.TabIndex = 15
        BtnUpdBooking.Text = "Actualizar reserva"
        BtnUpdBooking.UseVisualStyleBackColor = True
        ' 
        ' BtnDelBooking
        ' 
        BtnDelBooking.AutoSize = True
        BtnDelBooking.Font = New Font("Segoe UI", 12F)
        BtnDelBooking.Location = New Point(12, 217)
        BtnDelBooking.Name = "BtnDelBooking"
        BtnDelBooking.Size = New Size(156, 31)
        BtnDelBooking.TabIndex = 16
        BtnDelBooking.Text = "Eliminar reserva"
        BtnDelBooking.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(174, 217)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(156, 31)
        BtnCleanInputs.TabIndex = 17
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' DgvInfBooking
        ' 
        DgvInfBooking.AllowUserToAddRows = False
        DgvInfBooking.AllowUserToDeleteRows = False
        DgvInfBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfBooking.Location = New Point(336, 12)
        DgvInfBooking.Name = "DgvInfBooking"
        DgvInfBooking.ReadOnly = True
        DgvInfBooking.Size = New Size(436, 437)
        DgvInfBooking.TabIndex = 18
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(DgvInfBooking)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnDelBooking)
        Controls.Add(BtnUpdBooking)
        Controls.Add(BtnRegBooking)
        Controls.Add(DtpEnd)
        Controls.Add(Label6)
        Controls.Add(DtpStart)
        Controls.Add(Label5)
        Controls.Add(CbVehModelBooking)
        Controls.Add(Label4)
        Controls.Add(CbVehBrandBooking)
        Controls.Add(Label3)
        Controls.Add(CbCusIdentityBooking)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CbCustomersBooking)
        Controls.Add(BtnMainMenu)
        Name = "BookingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BookingForm"
        CType(DgvInfBooking, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents CbCustomersBooking As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbCusIdentityBooking As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbVehBrandBooking As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbVehModelBooking As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpStart As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpEnd As DateTimePicker
    Friend WithEvents BtnRegBooking As Button
    Friend WithEvents BtnUpdBooking As Button
    Friend WithEvents BtnDelBooking As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents DgvInfBooking As DataGridView
End Class
