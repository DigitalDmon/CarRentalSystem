<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        DgvInfClients = New DataGridView()
        TxtName = New TextBox()
        TxtLastName = New TextBox()
        TxtIdeNumber = New TextBox()
        TxtPhoNumber = New TextBox()
        TxtEmail = New TextBox()
        BtnRegClient = New Button()
        BtnCleanInputs = New Button()
        BtnToMainMenu = New Button()
        BtnDeleteClient = New Button()
        BtnUpdateClient = New Button()
        CType(DgvInfClients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvInfClients
        ' 
        DgvInfClients.AllowUserToAddRows = False
        DgvInfClients.AllowUserToDeleteRows = False
        DgvInfClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvInfClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders
        DgvInfClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfClients.Location = New Point(178, 12)
        DgvInfClients.Name = "DgvInfClients"
        DgvInfClients.ReadOnly = True
        DgvInfClients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvInfClients.Size = New Size(594, 437)
        DgvInfClients.TabIndex = 0
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 12F)
        TxtName.Location = New Point(12, 12)
        TxtName.Name = "TxtName"
        TxtName.PlaceholderText = "Nombre"
        TxtName.Size = New Size(160, 29)
        TxtName.TabIndex = 1
        ' 
        ' TxtLastName
        ' 
        TxtLastName.Font = New Font("Segoe UI", 12F)
        TxtLastName.Location = New Point(12, 47)
        TxtLastName.Name = "TxtLastName"
        TxtLastName.PlaceholderText = "Apellido"
        TxtLastName.Size = New Size(160, 29)
        TxtLastName.TabIndex = 2
        ' 
        ' TxtIdeNumber
        ' 
        TxtIdeNumber.Font = New Font("Segoe UI", 12F)
        TxtIdeNumber.Location = New Point(12, 82)
        TxtIdeNumber.Name = "TxtIdeNumber"
        TxtIdeNumber.PlaceholderText = "Número de identidad"
        TxtIdeNumber.Size = New Size(160, 29)
        TxtIdeNumber.TabIndex = 3
        ' 
        ' TxtPhoNumber
        ' 
        TxtPhoNumber.Font = New Font("Segoe UI", 12F)
        TxtPhoNumber.Location = New Point(12, 117)
        TxtPhoNumber.Name = "TxtPhoNumber"
        TxtPhoNumber.PlaceholderText = "Número de teléfono"
        TxtPhoNumber.Size = New Size(160, 29)
        TxtPhoNumber.TabIndex = 4
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Font = New Font("Segoe UI", 12F)
        TxtEmail.Location = New Point(12, 152)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.PlaceholderText = "Email"
        TxtEmail.Size = New Size(160, 29)
        TxtEmail.TabIndex = 5
        ' 
        ' BtnRegClient
        ' 
        BtnRegClient.AutoSize = True
        BtnRegClient.Font = New Font("Segoe UI", 12F)
        BtnRegClient.Location = New Point(12, 187)
        BtnRegClient.Name = "BtnRegClient"
        BtnRegClient.Size = New Size(160, 31)
        BtnRegClient.TabIndex = 6
        BtnRegClient.Text = "Registrar cliente"
        BtnRegClient.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(12, 298)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(160, 31)
        BtnCleanInputs.TabIndex = 7
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnToMainMenu
        ' 
        BtnToMainMenu.AutoSize = True
        BtnToMainMenu.Font = New Font("Segoe UI", 12F)
        BtnToMainMenu.Location = New Point(12, 418)
        BtnToMainMenu.Name = "BtnToMainMenu"
        BtnToMainMenu.Size = New Size(160, 31)
        BtnToMainMenu.TabIndex = 8
        BtnToMainMenu.Text = "Volver al menú"
        BtnToMainMenu.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteClient
        ' 
        BtnDeleteClient.Font = New Font("Segoe UI", 12F)
        BtnDeleteClient.Location = New Point(12, 224)
        BtnDeleteClient.Name = "BtnDeleteClient"
        BtnDeleteClient.Size = New Size(160, 31)
        BtnDeleteClient.TabIndex = 9
        BtnDeleteClient.Text = "Eliminar cliente"
        BtnDeleteClient.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdateClient
        ' 
        BtnUpdateClient.Font = New Font("Segoe UI", 12F)
        BtnUpdateClient.Location = New Point(12, 261)
        BtnUpdateClient.Name = "BtnUpdateClient"
        BtnUpdateClient.Size = New Size(160, 31)
        BtnUpdateClient.TabIndex = 10
        BtnUpdateClient.Text = "Actualizar cliente"
        BtnUpdateClient.UseVisualStyleBackColor = True
        ' 
        ' ClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(BtnUpdateClient)
        Controls.Add(BtnDeleteClient)
        Controls.Add(BtnToMainMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnRegClient)
        Controls.Add(TxtEmail)
        Controls.Add(TxtPhoNumber)
        Controls.Add(TxtIdeNumber)
        Controls.Add(TxtLastName)
        Controls.Add(TxtName)
        Controls.Add(DgvInfClients)
        Name = "ClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClientForm"
        CType(DgvInfClients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvInfClients As DataGridView
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents TxtIdeNumber As TextBox
    Friend WithEvents TxtPhoNumber As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnRegClient As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnToMainMenu As Button
    Friend WithEvents BtnDeleteClient As Button
    Friend WithEvents BtnUpdateClient As Button
End Class
