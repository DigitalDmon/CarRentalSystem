<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MechanicForm
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
        BtnUpdateMechanic = New Button()
        BtnToMainMenu = New Button()
        BtnCleanInputs = New Button()
        BtnRegMechanic = New Button()
        TxtSpecialityMechanic = New TextBox()
        TxtPhoneMechanic = New TextBox()
        TxtIdentityMechanic = New TextBox()
        Me.TxtLastnameMechanic = New TextBox()
        TxtNameMechanic = New TextBox()
        DgvInfMechanic = New DataGridView()
        CType(DgvInfMechanic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnUpdateMechanic
        ' 
        BtnUpdateMechanic.Font = New Font("Segoe UI", 12F)
        BtnUpdateMechanic.Location = New Point(8, 224)
        BtnUpdateMechanic.Name = "BtnUpdateMechanic"
        BtnUpdateMechanic.Size = New Size(160, 31)
        BtnUpdateMechanic.TabIndex = 32
        BtnUpdateMechanic.Text = "Actualizar vehículo"
        BtnUpdateMechanic.UseVisualStyleBackColor = True
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
        BtnCleanInputs.Location = New Point(8, 261)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(160, 31)
        BtnCleanInputs.TabIndex = 29
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnRegMechanic
        ' 
        BtnRegMechanic.AutoSize = True
        BtnRegMechanic.Font = New Font("Segoe UI", 12F)
        BtnRegMechanic.Location = New Point(8, 187)
        BtnRegMechanic.Name = "BtnRegMechanic"
        BtnRegMechanic.Size = New Size(160, 31)
        BtnRegMechanic.TabIndex = 28
        BtnRegMechanic.Text = "Registrar vehículo"
        BtnRegMechanic.UseVisualStyleBackColor = True
        ' 
        ' TxtSpecialityMechanic
        ' 
        TxtSpecialityMechanic.Font = New Font("Segoe UI", 12F)
        TxtSpecialityMechanic.Location = New Point(8, 152)
        TxtSpecialityMechanic.Name = "TxtSpecialityMechanic"
        TxtSpecialityMechanic.PlaceholderText = "Especialidad"
        TxtSpecialityMechanic.Size = New Size(160, 29)
        TxtSpecialityMechanic.TabIndex = 27
        ' 
        ' TxtPhoneMechanic
        ' 
        TxtPhoneMechanic.Font = New Font("Segoe UI", 12F)
        TxtPhoneMechanic.Location = New Point(8, 117)
        TxtPhoneMechanic.Name = "TxtPhoneMechanic"
        TxtPhoneMechanic.PlaceholderText = "Teléfono"
        TxtPhoneMechanic.Size = New Size(160, 29)
        TxtPhoneMechanic.TabIndex = 26
        ' 
        ' TxtIdentityMechanic
        ' 
        TxtIdentityMechanic.Font = New Font("Segoe UI", 12F)
        TxtIdentityMechanic.Location = New Point(8, 82)
        TxtIdentityMechanic.Name = "TxtIdentityMechanic"
        TxtIdentityMechanic.PlaceholderText = "Cédula"
        TxtIdentityMechanic.Size = New Size(160, 29)
        TxtIdentityMechanic.TabIndex = 25
        ' 
        ' TxtLastnameMechanic
        ' 
        Me.TxtLastnameMechanic.Font = New Font("Segoe UI", 12F)
        Me.TxtLastnameMechanic.Location = New Point(8, 47)
        Me.TxtLastnameMechanic.Name = "TxtLastnameMechanic"
        Me.TxtLastnameMechanic.PlaceholderText = "Apellido"
        Me.TxtLastnameMechanic.Size = New Size(160, 29)
        Me.TxtLastnameMechanic.TabIndex = 24
        ' 
        ' TxtNameMechanic
        ' 
        TxtNameMechanic.Font = New Font("Segoe UI", 12F)
        TxtNameMechanic.Location = New Point(8, 12)
        TxtNameMechanic.Name = "TxtNameMechanic"
        TxtNameMechanic.PlaceholderText = "Nombre"
        TxtNameMechanic.Size = New Size(160, 29)
        TxtNameMechanic.TabIndex = 23
        ' 
        ' DgvInfMechanic
        ' 
        DgvInfMechanic.AllowUserToAddRows = False
        DgvInfMechanic.AllowUserToDeleteRows = False
        DgvInfMechanic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvInfMechanic.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders
        DgvInfMechanic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfMechanic.Location = New Point(182, 12)
        DgvInfMechanic.Name = "DgvInfMechanic"
        DgvInfMechanic.ReadOnly = True
        DgvInfMechanic.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvInfMechanic.Size = New Size(594, 437)
        DgvInfMechanic.TabIndex = 22
        ' 
        ' MechanicForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(BtnUpdateMechanic)
        Controls.Add(BtnToMainMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnRegMechanic)
        Controls.Add(TxtSpecialityMechanic)
        Controls.Add(TxtPhoneMechanic)
        Controls.Add(TxtIdentityMechanic)
        Controls.Add(Me.TxtLastnameMechanic)
        Controls.Add(TxtNameMechanic)
        Controls.Add(DgvInfMechanic)
        Name = "MechanicForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MechanicForm"
        CType(DgvInfMechanic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnUpdateMechanic As Button
    Friend WithEvents BtnDeleteVehicle As Button
    Friend WithEvents BtnToMainMenu As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnRegMechanic As Button
    Friend WithEvents TxtSpecialityMechanic As TextBox
    Friend WithEvents TxtPhoneMechanic As TextBox
    Friend WithEvents TxtIdentityMechanic As TextBox
    Friend WithEvents TxtModel As TextBox
    Friend WithEvents TxtNameMechanic As TextBox
    Friend WithEvents DgvInfMechanic As DataGridView
End Class
