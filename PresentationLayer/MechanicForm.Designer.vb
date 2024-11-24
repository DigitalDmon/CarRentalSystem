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
        TxtName = New TextBox()
        TxtLastname = New TextBox()
        TxtIdentity = New TextBox()
        TxtSpeciality = New TextBox()
        TxtPhone = New TextBox()
        BtnRegMechanic = New Button()
        BtnUpdMechanic = New Button()
        BtnCleanInputs = New Button()
        BtnBackToMenu = New Button()
        DgvInfMechanics = New DataGridView()
        CType(DgvInfMechanics, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 12F)
        TxtName.Location = New Point(12, 12)
        TxtName.Name = "TxtName"
        TxtName.PlaceholderText = "Nombre"
        TxtName.Size = New Size(158, 29)
        TxtName.TabIndex = 0
        ' 
        ' TxtLastname
        ' 
        TxtLastname.Font = New Font("Segoe UI", 12F)
        TxtLastname.Location = New Point(12, 49)
        TxtLastname.Name = "TxtLastname"
        TxtLastname.PlaceholderText = "Apellido"
        TxtLastname.Size = New Size(158, 29)
        TxtLastname.TabIndex = 1
        ' 
        ' TxtIdentity
        ' 
        TxtIdentity.Font = New Font("Segoe UI", 12F)
        TxtIdentity.Location = New Point(12, 86)
        TxtIdentity.Name = "TxtIdentity"
        TxtIdentity.PlaceholderText = "Cédula"
        TxtIdentity.Size = New Size(158, 29)
        TxtIdentity.TabIndex = 2
        ' 
        ' TxtSpeciality
        ' 
        TxtSpeciality.Font = New Font("Segoe UI", 12F)
        TxtSpeciality.Location = New Point(12, 123)
        TxtSpeciality.Name = "TxtSpeciality"
        TxtSpeciality.PlaceholderText = "Especialidad"
        TxtSpeciality.Size = New Size(158, 29)
        TxtSpeciality.TabIndex = 3
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Font = New Font("Segoe UI", 12F)
        TxtPhone.Location = New Point(12, 160)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.PlaceholderText = "Teléfono"
        TxtPhone.Size = New Size(158, 29)
        TxtPhone.TabIndex = 4
        ' 
        ' BtnRegMechanic
        ' 
        BtnRegMechanic.AutoSize = True
        BtnRegMechanic.Font = New Font("Segoe UI", 12F)
        BtnRegMechanic.Location = New Point(12, 195)
        BtnRegMechanic.Name = "BtnRegMechanic"
        BtnRegMechanic.Size = New Size(158, 31)
        BtnRegMechanic.TabIndex = 5
        BtnRegMechanic.Text = "Registrar mecánico"
        BtnRegMechanic.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdMechanic
        ' 
        BtnUpdMechanic.AutoSize = True
        BtnUpdMechanic.Font = New Font("Segoe UI", 12F)
        BtnUpdMechanic.Location = New Point(12, 232)
        BtnUpdMechanic.Name = "BtnUpdMechanic"
        BtnUpdMechanic.Size = New Size(158, 31)
        BtnUpdMechanic.TabIndex = 6
        BtnUpdMechanic.Text = "Actualizar mecánico"
        BtnUpdMechanic.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(12, 269)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(158, 31)
        BtnCleanInputs.TabIndex = 7
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnBackToMenu
        ' 
        BtnBackToMenu.AutoSize = True
        BtnBackToMenu.Font = New Font("Segoe UI", 12F)
        BtnBackToMenu.Location = New Point(12, 418)
        BtnBackToMenu.Name = "BtnBackToMenu"
        BtnBackToMenu.Size = New Size(158, 31)
        BtnBackToMenu.TabIndex = 8
        BtnBackToMenu.Text = "Volver al menú"
        BtnBackToMenu.UseVisualStyleBackColor = True
        ' 
        ' DgvInfMechanics
        ' 
        DgvInfMechanics.AllowUserToAddRows = False
        DgvInfMechanics.AllowUserToDeleteRows = False
        DgvInfMechanics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfMechanics.Location = New Point(176, 12)
        DgvInfMechanics.Name = "DgvInfMechanics"
        DgvInfMechanics.ReadOnly = True
        DgvInfMechanics.Size = New Size(596, 437)
        DgvInfMechanics.TabIndex = 9
        ' 
        ' MechanicForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(DgvInfMechanics)
        Controls.Add(BtnBackToMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnUpdMechanic)
        Controls.Add(BtnRegMechanic)
        Controls.Add(TxtPhone)
        Controls.Add(TxtSpeciality)
        Controls.Add(TxtIdentity)
        Controls.Add(TxtLastname)
        Controls.Add(TxtName)
        Name = "MechanicForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MechanicForm"
        CType(DgvInfMechanics, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtLastname As TextBox
    Friend WithEvents TxtIdentity As TextBox
    Friend WithEvents TxtSpeciality As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents BtnRegMechanic As Button
    Friend WithEvents BtnUpdMechanic As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnBackToMenu As Button
    Friend WithEvents DgvInfMechanics As DataGridView
End Class
