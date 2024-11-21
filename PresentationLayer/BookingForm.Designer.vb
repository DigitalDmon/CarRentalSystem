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
        BtnUpdateBooking = New Button()
        BtnDeleteBooking = New Button()
        BtnToMainMenu = New Button()
        BtnCleanInputs = New Button()
        BtnRegBooking = New Button()
        DgvInfBookings = New DataGridView()
        CbCustomersBooking = New ComboBox()
        Me.CbVehiclesBooking = New ComboBox()
        DtpStart = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        DtpEnd = New DateTimePicker()
        CType(DgvInfBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnUpdateBooking
        ' 
        BtnUpdateBooking.Font = New Font("Segoe UI", 12F)
        BtnUpdateBooking.Location = New Point(8, 268)
        BtnUpdateBooking.Name = "BtnUpdateBooking"
        BtnUpdateBooking.Size = New Size(160, 31)
        BtnUpdateBooking.TabIndex = 32
        BtnUpdateBooking.Text = "Actualizar reserva"
        BtnUpdateBooking.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteBooking
        ' 
        BtnDeleteBooking.Font = New Font("Segoe UI", 12F)
        BtnDeleteBooking.Location = New Point(8, 231)
        BtnDeleteBooking.Name = "BtnDeleteBooking"
        BtnDeleteBooking.Size = New Size(160, 31)
        BtnDeleteBooking.TabIndex = 31
        BtnDeleteBooking.Text = "Eliminar reserva"
        BtnDeleteBooking.UseVisualStyleBackColor = True
        ' 
        ' BtnToMainMenu
        ' 
        BtnToMainMenu.AutoSize = True
        BtnToMainMenu.Font = New Font("Segoe UI", 12F)
        BtnToMainMenu.Location = New Point(8, 418)
        BtnToMainMenu.Name = "BtnToMainMenu"
        BtnToMainMenu.Size = New Size(160, 31)
        BtnToMainMenu.TabIndex = 30
        BtnToMainMenu.Text = "Volver al menú"
        BtnToMainMenu.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(8, 305)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(160, 31)
        BtnCleanInputs.TabIndex = 29
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnRegBooking
        ' 
        BtnRegBooking.AutoSize = True
        BtnRegBooking.Font = New Font("Segoe UI", 12F)
        BtnRegBooking.Location = New Point(8, 194)
        BtnRegBooking.Name = "BtnRegBooking"
        BtnRegBooking.Size = New Size(160, 31)
        BtnRegBooking.TabIndex = 28
        BtnRegBooking.Text = "Registrar reserva"
        BtnRegBooking.UseVisualStyleBackColor = True
        ' 
        ' DgvInfBookings
        ' 
        DgvInfBookings.AllowUserToAddRows = False
        DgvInfBookings.AllowUserToDeleteRows = False
        DgvInfBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvInfBookings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders
        DgvInfBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfBookings.Location = New Point(174, 12)
        DgvInfBookings.Name = "DgvInfBookings"
        DgvInfBookings.ReadOnly = True
        DgvInfBookings.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvInfBookings.Size = New Size(602, 437)
        DgvInfBookings.TabIndex = 22
        ' 
        ' CbCustomersBooking
        ' 
        CbCustomersBooking.Font = New Font("Segoe UI", 12F)
        CbCustomersBooking.FormattingEnabled = True
        CbCustomersBooking.Location = New Point(8, 12)
        CbCustomersBooking.Name = "CbCustomersBooking"
        CbCustomersBooking.Size = New Size(160, 29)
        CbCustomersBooking.TabIndex = 33
        CbCustomersBooking.Text = "Cliente"
        ' 
        ' CbVehiclesBooking
        ' 
        Me.CbVehiclesBooking.Font = New Font("Segoe UI", 12F)
        Me.CbVehiclesBooking.FormattingEnabled = True
        Me.CbVehiclesBooking.Location = New Point(8, 47)
        Me.CbVehiclesBooking.Name = "CbVehiclesBooking"
        Me.CbVehiclesBooking.Size = New Size(160, 29)
        Me.CbVehiclesBooking.TabIndex = 34
        Me.CbVehiclesBooking.Text = "Vehículo"
        ' 
        ' DtpStart
        ' 
        DtpStart.Font = New Font("Segoe UI", 12F)
        DtpStart.Location = New Point(8, 103)
        DtpStart.Name = "DtpStart"
        DtpStart.Size = New Size(160, 29)
        DtpStart.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(8, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 21)
        Label1.TabIndex = 36
        Label1.Text = "Fecha inicial :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(8, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 37
        Label2.Text = "Fecha final:"
        ' 
        ' DtpEnd
        ' 
        DtpEnd.Font = New Font("Segoe UI", 12F)
        DtpEnd.Location = New Point(8, 159)
        DtpEnd.Name = "DtpEnd"
        DtpEnd.Size = New Size(160, 29)
        DtpEnd.TabIndex = 38
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(DtpEnd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DtpStart)
        Controls.Add(Me.CbVehiclesBooking)
        Controls.Add(CbCustomersBooking)
        Controls.Add(BtnUpdateBooking)
        Controls.Add(BtnDeleteBooking)
        Controls.Add(BtnToMainMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnRegBooking)
        Controls.Add(DgvInfBookings)
        Name = "BookingForm"
        Text = "BookingForm"
        CType(DgvInfBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnUpdateBooking As Button
    Friend WithEvents BtnDeleteBooking As Button
    Friend WithEvents BtnToMainMenu As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnRegBooking As Button
    Friend WithEvents TxtFuel As TextBox
    Friend WithEvents TxtPlate As TextBox
    Friend WithEvents DgvInfBookings As DataGridView
    Friend WithEvents CbCustomersBooking As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DtpStart As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpEnd As DateTimePicker
End Class
