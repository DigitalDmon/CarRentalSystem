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
        BtnUpdList = New Button()
        CType(DgvInfClients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvInfClients
        ' 
        DgvInfClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfClients.Location = New Point(143, 43)
        DgvInfClients.Name = "DgvInfClients"
        DgvInfClients.Size = New Size(729, 150)
        DgvInfClients.TabIndex = 0
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(12, 12)
        TxtName.Name = "TxtName"
        TxtName.PlaceholderText = "Nombre"
        TxtName.Size = New Size(125, 23)
        TxtName.TabIndex = 1
        ' 
        ' TxtLastName
        ' 
        TxtLastName.Location = New Point(12, 41)
        TxtLastName.Name = "TxtLastName"
        TxtLastName.PlaceholderText = "Apellido"
        TxtLastName.Size = New Size(125, 23)
        TxtLastName.TabIndex = 2
        ' 
        ' TxtIdeNumber
        ' 
        TxtIdeNumber.Location = New Point(12, 70)
        TxtIdeNumber.Name = "TxtIdeNumber"
        TxtIdeNumber.PlaceholderText = "Número de identidad"
        TxtIdeNumber.Size = New Size(125, 23)
        TxtIdeNumber.TabIndex = 3
        ' 
        ' TxtPhoNumber
        ' 
        TxtPhoNumber.Location = New Point(12, 99)
        TxtPhoNumber.Name = "TxtPhoNumber"
        TxtPhoNumber.PlaceholderText = "Número de teléfono"
        TxtPhoNumber.Size = New Size(125, 23)
        TxtPhoNumber.TabIndex = 4
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(12, 128)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.PlaceholderText = "Email"
        TxtEmail.Size = New Size(125, 23)
        TxtEmail.TabIndex = 5
        ' 
        ' BtnRegClient
        ' 
        BtnRegClient.AutoSize = True
        BtnRegClient.Location = New Point(12, 157)
        BtnRegClient.Name = "BtnRegClient"
        BtnRegClient.Size = New Size(101, 25)
        BtnRegClient.TabIndex = 6
        BtnRegClient.Text = "Registrar cliente"
        BtnRegClient.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdList
        ' 
        BtnUpdList.AutoSize = True
        BtnUpdList.Location = New Point(143, 12)
        BtnUpdList.Name = "BtnUpdList"
        BtnUpdList.Size = New Size(101, 25)
        BtnUpdList.TabIndex = 7
        BtnUpdList.Text = "Actualizar lista"
        BtnUpdList.UseVisualStyleBackColor = True
        ' 
        ' ClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(BtnUpdList)
        Controls.Add(BtnRegClient)
        Controls.Add(TxtEmail)
        Controls.Add(TxtPhoNumber)
        Controls.Add(TxtIdeNumber)
        Controls.Add(TxtLastName)
        Controls.Add(TxtName)
        Controls.Add(DgvInfClients)
        Name = "ClientForm"
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
    Friend WithEvents BtnUpdList As Button
End Class
