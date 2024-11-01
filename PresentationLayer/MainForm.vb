Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Instanciar la clase de conexión
        Dim dbConnection As New DatabaseConnection()

        ' Llamar al método ObtenerDatos con una consulta SQL
        Dim query As String = "SELECT * FROM customers"
        Dim dataTable As DataTable = dbConnection.ObtenerDatos(query)

        ' Mostrar los datos en un DataGridView (por ejemplo)
        DataGridView1.DataSource = dataTable

    End Sub
End Class