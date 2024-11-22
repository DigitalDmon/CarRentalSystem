<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceForm
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
        BtnToMainMenu = New Button()
        BtnCleanInputs = New Button()
        BtnRegMaintenance = New Button()
        DgvInfMaintenance = New DataGridView()
        CbVehPlateMaintenance = New ComboBox()
        Label1 = New Label()
        DtpMaintenance = New DateTimePicker()
        Label2 = New Label()
        TxtDescriptionMaintenance = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        CbNameMechanic = New ComboBox()
        CType(DgvInfMaintenance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnToMainMenu
        ' 
        BtnToMainMenu.AutoSize = True
        BtnToMainMenu.Font = New Font("Segoe UI", 12F)
        BtnToMainMenu.Location = New Point(12, 418)
        BtnToMainMenu.Name = "BtnToMainMenu"
        BtnToMainMenu.Size = New Size(200, 31)
        BtnToMainMenu.TabIndex = 30
        BtnToMainMenu.Text = "Volver al menú"
        BtnToMainMenu.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(12, 319)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(200, 31)
        BtnCleanInputs.TabIndex = 29
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnRegMaintenance
        ' 
        BtnRegMaintenance.AutoSize = True
        BtnRegMaintenance.Font = New Font("Segoe UI", 12F)
        BtnRegMaintenance.Location = New Point(12, 282)
        BtnRegMaintenance.Name = "BtnRegMaintenance"
        BtnRegMaintenance.Size = New Size(200, 31)
        BtnRegMaintenance.TabIndex = 28
        BtnRegMaintenance.Text = "Registrar mantenimientos"
        BtnRegMaintenance.UseVisualStyleBackColor = True
        ' 
        ' DgvInfMaintenance
        ' 
        DgvInfMaintenance.AllowUserToAddRows = False
        DgvInfMaintenance.AllowUserToDeleteRows = False
        DgvInfMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvInfMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders
        DgvInfMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfMaintenance.Location = New Point(218, 12)
        DgvInfMaintenance.Name = "DgvInfMaintenance"
        DgvInfMaintenance.ReadOnly = True
        DgvInfMaintenance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvInfMaintenance.Size = New Size(554, 437)
        DgvInfMaintenance.TabIndex = 22
        ' 
        ' CbVehPlateMaintenance
        ' 
        CbVehPlateMaintenance.Font = New Font("Segoe UI", 12F)
        CbVehPlateMaintenance.FormattingEnabled = True
        CbVehPlateMaintenance.Location = New Point(12, 33)
        CbVehPlateMaintenance.Name = "CbVehPlateMaintenance"
        CbVehPlateMaintenance.Size = New Size(200, 29)
        CbVehPlateMaintenance.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 21)
        Label1.TabIndex = 34
        Label1.Text = "Placa de vehículo:"
        ' 
        ' DtpMaintenance
        ' 
        DtpMaintenance.Font = New Font("Segoe UI", 12F)
        DtpMaintenance.Location = New Point(12, 89)
        DtpMaintenance.Name = "DtpMaintenance"
        DtpMaintenance.Size = New Size(200, 29)
        DtpMaintenance.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(12, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 21)
        Label2.TabIndex = 36
        Label2.Text = "Fecha del mantenimiento:"
        ' 
        ' TxtDescriptionMaintenance
        ' 
        TxtDescriptionMaintenance.Font = New Font("Segoe UI", 12F)
        TxtDescriptionMaintenance.Location = New Point(12, 201)
        TxtDescriptionMaintenance.Multiline = True
        TxtDescriptionMaintenance.Name = "TxtDescriptionMaintenance"
        TxtDescriptionMaintenance.Size = New Size(200, 75)
        TxtDescriptionMaintenance.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(12, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 21)
        Label3.TabIndex = 38
        Label3.Text = "Descripción:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(12, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 39
        Label4.Text = "Mecánico:"
        ' 
        ' CbNameMechanic
        ' 
        CbNameMechanic.Font = New Font("Segoe UI", 12F)
        CbNameMechanic.FormattingEnabled = True
        CbNameMechanic.Location = New Point(12, 145)
        CbNameMechanic.Name = "CbNameMechanic"
        CbNameMechanic.Size = New Size(200, 29)
        CbNameMechanic.TabIndex = 40
        ' 
        ' MaintenanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(CbNameMechanic)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TxtDescriptionMaintenance)
        Controls.Add(Label2)
        Controls.Add(DtpMaintenance)
        Controls.Add(Label1)
        Controls.Add(CbVehPlateMaintenance)
        Controls.Add(BtnToMainMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnRegMaintenance)
        Controls.Add(DgvInfMaintenance)
        Name = "MaintenanceForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MaintenanceForm"
        CType(DgvInfMaintenance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnToMainMenu As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnRegMaintenance As Button
    Friend WithEvents DgvInfMaintenance As DataGridView
    Friend WithEvents CbVehPlateMaintenance As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpMaintenance As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescriptionMaintenance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbNameMechanic As ComboBox
End Class
