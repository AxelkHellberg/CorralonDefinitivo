Imports Domain
Imports System.Data.SqlClient

Public Class FormProveedores
    Private Sub BotonClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

#Region "Drag Forms"

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.BringToFront()
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Me.BringToFront()
    End Sub



#End Region

#Region "Conexion a SQL"


    Private connectionString As String
    Public Sub conectar()
        'connectionString = "Server=IGGI662\PRUEBA1; DataBase=VerdaderoBackupSanJusto; integrated security= true"
        connectionString = "Server=45.169.100.7; DataBase=sanjusto_corralon; User Id=sanjusto_sanjusto ; Password=sz2dKOe&Y9~J35"
    End Sub
    Public Function GetConnection() As SqlConnection
        conectar()
        Return New SqlConnection(connectionString)
    End Function

#End Region

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If String.IsNullOrEmpty(TextProveedor.Text) Then
                    MessageBox.Show("Debe rellenar el campo 'Proveedor'")
                    Exit Sub
                Else
                    command.CommandText = "select nombre as Proveedor,deuda as Deuda FROM proveedor WHERE nombre LIKE '%'+@nombre+'%' and nombre<>'(seleccionar proveedor)'"
                    command.Parameters.AddWithValue("@nombre", TextProveedor.Text)
                    command.CommandType = CommandType.Text
                End If

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    DataGridViewBusqueda.Columns.Clear()
                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridViewBusqueda.DataSource = db
                    da2.Dispose()

                    DataGridViewBusqueda.Focus()

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    MessageBox.Show("No se encontro ningun proveedor con ese nombre" + vbNewLine + "lo puede crear precionando 'agregar proveedor'.")
                    da2.Dispose()
                End If


            End Using
        End Using
    End Sub

    Private Sub BotonAgregarProveedor_Click(sender As Object, e As EventArgs) Handles BotonAgregarProveedor.Click
        Dim userModel As New UserModel()
        Try
            Dim valid = userModel.agregarProveedor(TextProveedor.Text)
            BotonBuscar_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error no puede existir dos proveedores con el mismo nombre.")
        End Try
    End Sub

    Private Sub BotonClose_Click_1(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

    Private Sub TextProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles TextProveedor.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonBuscar_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextCaja_TextChanged(sender As Object, e As EventArgs) Handles TextCaja.TextChanged

        Dim total As Double = 0
        Dim cajaDouble As Double
        Dim tesoroDouble As Double
        Dim bancoDouble As Double

        Double.TryParse(TextCaja.Text, cajaDouble)
        Double.TryParse(TextTesoro.Text, tesoroDouble)
        Double.TryParse(TextBanco.Text, bancoDouble)


        total = cajaDouble + tesoroDouble + bancoDouble

        TotalNum.Text = total.ToString()

    End Sub

    Private Sub TextTesoro_TextChanged(sender As Object, e As EventArgs) Handles TextTesoro.TextChanged
        Dim total As Double = 0
        Dim cajaDouble As Double
        Dim tesoroDouble As Double
        Dim bancoDouble As Double

        Double.TryParse(TextCaja.Text, cajaDouble)
        Double.TryParse(TextTesoro.Text, tesoroDouble)
        Double.TryParse(TextBanco.Text, bancoDouble)


        total = cajaDouble + tesoroDouble + bancoDouble

        TotalNum.Text = total.ToString()

    End Sub

    Private Sub TextBanco_TextChanged(sender As Object, e As EventArgs) Handles TextBanco.TextChanged
        Dim total As Double = 0
        Dim cajaDouble As Double
        Dim tesoroDouble As Double
        Dim bancoDouble As Double

        Double.TryParse(TextCaja.Text, cajaDouble)
        Double.TryParse(TextTesoro.Text, tesoroDouble)
        Double.TryParse(TextBanco.Text, bancoDouble)


        total = cajaDouble + tesoroDouble + bancoDouble

        TotalNum.Text = total.ToString()
    End Sub

    Private Sub DataGridViewBusqueda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBusqueda.CellDoubleClick, DataGridViewBusqueda.CellEnter
        ProveedorSelect.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
    End Sub

    Private Sub BotonPagar_Click(sender As Object, e As EventArgs) Handles BotonPagar.Click
        Dim total As Double = 0
        Dim cajaDouble As Double
        Dim tesoroDouble As Double
        Dim bancoDouble As Double
        Dim userModel As New UserModel()
        Double.TryParse(TextCaja.Text, cajaDouble)
        Double.TryParse(TextTesoro.Text, tesoroDouble)
        Double.TryParse(TextBanco.Text, bancoDouble)

        total = cajaDouble + tesoroDouble + bancoDouble

        Dim valid = UserModel.PagarProveedor(cajaDouble, tesoroDouble, bancoDouble, total, ProveedorSelect.Text)

        If valid = False Then
            MessageBox.Show("Error al acumular el producto RESTAR" + vbNewLine + "Por favor, intente nuevamente.")
        Else
            MessageBox.Show("Se realizo correctamente el pago.")
        End If

        DataGridViewBusqueda.Columns.Clear()
        TextCaja.Text = "0"
        TextTesoro.Text = "0"
        TextBanco.Text = "0"
        ProveedorSelect.Text = "(sin seleccionar proveedor)"
        TotalNum.Text = "0"
        TextProveedor.Clear()
    End Sub
End Class