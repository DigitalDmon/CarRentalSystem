<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        CmbBooking = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        NudAmount = New NumericUpDown()
        CmbPayMethod = New ComboBox()
        Label3 = New Label()
        DgvInfPayments = New DataGridView()
        BtnRegPayment = New Button()
        BtnCleanInputs = New Button()
        BtnBackToMenu = New Button()
        CType(NudAmount, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvInfPayments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CmbBooking
        ' 
        CmbBooking.Font = New Font("Segoe UI", 12F)
        CmbBooking.FormattingEnabled = True
        CmbBooking.Location = New Point(12, 33)
        CmbBooking.Name = "CmbBooking"
        CmbBooking.Size = New Size(147, 29)
        CmbBooking.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 21)
        Label1.TabIndex = 1
        Label1.Text = "Número de reserva:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(12, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 21)
        Label2.TabIndex = 2
        Label2.Text = "Monto a pagar:"
        ' 
        ' NudAmount
        ' 
        NudAmount.DecimalPlaces = 2
        NudAmount.Font = New Font("Segoe UI", 12F)
        NudAmount.Location = New Point(12, 89)
        NudAmount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        NudAmount.Name = "NudAmount"
        NudAmount.Size = New Size(147, 29)
        NudAmount.TabIndex = 3
        ' 
        ' CmbPayMethod
        ' 
        CmbPayMethod.Font = New Font("Segoe UI", 12F)
        CmbPayMethod.FormattingEnabled = True
        CmbPayMethod.Location = New Point(12, 145)
        CmbPayMethod.Name = "CmbPayMethod"
        CmbPayMethod.Size = New Size(147, 29)
        CmbPayMethod.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(12, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 5
        Label3.Text = "Método de pago:"
        ' 
        ' DgvInfPayments
        ' 
        DgvInfPayments.AllowUserToAddRows = False
        DgvInfPayments.AllowUserToDeleteRows = False
        DgvInfPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfPayments.Location = New Point(165, 12)
        DgvInfPayments.Name = "DgvInfPayments"
        DgvInfPayments.ReadOnly = True
        DgvInfPayments.Size = New Size(607, 437)
        DgvInfPayments.TabIndex = 8
        ' 
        ' BtnRegPayment
        ' 
        BtnRegPayment.AutoSize = True
        BtnRegPayment.Font = New Font("Segoe UI", 12F)
        BtnRegPayment.Location = New Point(12, 180)
        BtnRegPayment.Name = "BtnRegPayment"
        BtnRegPayment.Size = New Size(147, 31)
        BtnRegPayment.TabIndex = 9
        BtnRegPayment.Text = "Registrar pago"
        BtnRegPayment.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(12, 217)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(147, 31)
        BtnCleanInputs.TabIndex = 10
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnBackToMenu
        ' 
        BtnBackToMenu.AutoSize = True
        BtnBackToMenu.Font = New Font("Segoe UI", 12F)
        BtnBackToMenu.Location = New Point(12, 418)
        BtnBackToMenu.Name = "BtnBackToMenu"
        BtnBackToMenu.Size = New Size(147, 31)
        BtnBackToMenu.TabIndex = 11
        BtnBackToMenu.Text = "Volver al menú"
        BtnBackToMenu.UseVisualStyleBackColor = True
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(BtnBackToMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnRegPayment)
        Controls.Add(DgvInfPayments)
        Controls.Add(Label3)
        Controls.Add(CmbPayMethod)
        Controls.Add(NudAmount)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CmbBooking)
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaymentForm"
        CType(NudAmount, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvInfPayments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmbBooking As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NudAmount As NumericUpDown
    Friend WithEvents CmbPayMethod As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvInfPayments As DataGridView
    Friend WithEvents BtnRegPayment As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnBackToMenu As Button
End Class
