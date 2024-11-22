<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleForm
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
        BtnUpdateVehicle = New Button()
        BtnDeleteVehicle = New Button()
        BtnToMainMenu = New Button()
        BtnCleanInputs = New Button()
        BtnRegVehicle = New Button()
        TxtFuel = New TextBox()
        TxtPlate = New TextBox()
        TxtYear = New TextBox()
        TxtModel = New TextBox()
        TxtBrand = New TextBox()
        DgvInfVehicles = New DataGridView()
        CType(DgvInfVehicles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnUpdateVehicle
        ' 
        BtnUpdateVehicle.Font = New Font("Segoe UI", 12F)
        BtnUpdateVehicle.Location = New Point(12, 256)
        BtnUpdateVehicle.Name = "BtnUpdateVehicle"
        BtnUpdateVehicle.Size = New Size(160, 31)
        BtnUpdateVehicle.TabIndex = 21
        BtnUpdateVehicle.Text = "Actualizar vehículo"
        BtnUpdateVehicle.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteVehicle
        ' 
        BtnDeleteVehicle.Font = New Font("Segoe UI", 12F)
        BtnDeleteVehicle.Location = New Point(12, 219)
        BtnDeleteVehicle.Name = "BtnDeleteVehicle"
        BtnDeleteVehicle.Size = New Size(160, 31)
        BtnDeleteVehicle.TabIndex = 20
        BtnDeleteVehicle.Text = "Eliminar vehículo"
        BtnDeleteVehicle.UseVisualStyleBackColor = True
        ' 
        ' BtnToMainMenu
        ' 
        BtnToMainMenu.AutoSize = True
        BtnToMainMenu.Font = New Font("Segoe UI", 12F)
        BtnToMainMenu.Location = New Point(12, 413)
        BtnToMainMenu.Name = "BtnToMainMenu"
        BtnToMainMenu.Size = New Size(160, 31)
        BtnToMainMenu.TabIndex = 19
        BtnToMainMenu.Text = "Volver al menú"
        BtnToMainMenu.UseVisualStyleBackColor = True
        ' 
        ' BtnCleanInputs
        ' 
        BtnCleanInputs.AutoSize = True
        BtnCleanInputs.Font = New Font("Segoe UI", 12F)
        BtnCleanInputs.Location = New Point(12, 293)
        BtnCleanInputs.Name = "BtnCleanInputs"
        BtnCleanInputs.Size = New Size(160, 31)
        BtnCleanInputs.TabIndex = 18
        BtnCleanInputs.Text = "Limpiar campos"
        BtnCleanInputs.UseVisualStyleBackColor = True
        ' 
        ' BtnRegVehicle
        ' 
        BtnRegVehicle.AutoSize = True
        BtnRegVehicle.Font = New Font("Segoe UI", 12F)
        BtnRegVehicle.Location = New Point(12, 182)
        BtnRegVehicle.Name = "BtnRegVehicle"
        BtnRegVehicle.Size = New Size(160, 31)
        BtnRegVehicle.TabIndex = 17
        BtnRegVehicle.Text = "Registrar vehículo"
        BtnRegVehicle.UseVisualStyleBackColor = True
        ' 
        ' TxtFuel
        ' 
        TxtFuel.Font = New Font("Segoe UI", 12F)
        TxtFuel.Location = New Point(12, 147)
        TxtFuel.Name = "TxtFuel"
        TxtFuel.PlaceholderText = "Combustible"
        TxtFuel.Size = New Size(160, 29)
        TxtFuel.TabIndex = 16
        ' 
        ' TxtPlate
        ' 
        TxtPlate.Font = New Font("Segoe UI", 12F)
        TxtPlate.Location = New Point(12, 112)
        TxtPlate.Name = "TxtPlate"
        TxtPlate.PlaceholderText = "Placa"
        TxtPlate.Size = New Size(160, 29)
        TxtPlate.TabIndex = 15
        ' 
        ' TxtYear
        ' 
        TxtYear.Font = New Font("Segoe UI", 12F)
        TxtYear.Location = New Point(12, 77)
        TxtYear.Name = "TxtYear"
        TxtYear.PlaceholderText = "Año"
        TxtYear.Size = New Size(160, 29)
        TxtYear.TabIndex = 14
        ' 
        ' TxtModel
        ' 
        TxtModel.Font = New Font("Segoe UI", 12F)
        TxtModel.Location = New Point(12, 42)
        TxtModel.Name = "TxtModel"
        TxtModel.PlaceholderText = "Modelo"
        TxtModel.Size = New Size(160, 29)
        TxtModel.TabIndex = 13
        ' 
        ' TxtBrand
        ' 
        TxtBrand.Font = New Font("Segoe UI", 12F)
        TxtBrand.Location = New Point(12, 7)
        TxtBrand.Name = "TxtBrand"
        TxtBrand.PlaceholderText = "Marca"
        TxtBrand.Size = New Size(160, 29)
        TxtBrand.TabIndex = 12
        ' 
        ' DgvInfVehicles
        ' 
        DgvInfVehicles.AllowUserToAddRows = False
        DgvInfVehicles.AllowUserToDeleteRows = False
        DgvInfVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvInfVehicles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders
        DgvInfVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInfVehicles.Location = New Point(186, 7)
        DgvInfVehicles.Name = "DgvInfVehicles"
        DgvInfVehicles.ReadOnly = True
        DgvInfVehicles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvInfVehicles.Size = New Size(594, 437)
        DgvInfVehicles.TabIndex = 11
        ' 
        ' VehicleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(BtnUpdateVehicle)
        Controls.Add(BtnDeleteVehicle)
        Controls.Add(BtnToMainMenu)
        Controls.Add(BtnCleanInputs)
        Controls.Add(BtnRegVehicle)
        Controls.Add(TxtFuel)
        Controls.Add(TxtPlate)
        Controls.Add(TxtYear)
        Controls.Add(TxtModel)
        Controls.Add(TxtBrand)
        Controls.Add(DgvInfVehicles)
        Name = "VehicleForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VehicleForm"
        CType(DgvInfVehicles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnUpdateVehicle As Button
    Friend WithEvents BtnDeleteVehicle As Button
    Friend WithEvents BtnToMainMenu As Button
    Friend WithEvents BtnCleanInputs As Button
    Friend WithEvents BtnRegVehicle As Button
    Friend WithEvents TxtFuel As TextBox
    Friend WithEvents TxtPlate As TextBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents TxtModel As TextBox
    Friend WithEvents TxtBrand As TextBox
    Friend WithEvents DgvInfVehicles As DataGridView
End Class
