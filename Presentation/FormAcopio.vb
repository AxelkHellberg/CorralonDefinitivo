Imports Domain
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.SqlClient
Imports System.IO
Imports CapaComun
Public Class FormAcopio


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
    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles panelContenedor.MouseClick
        Me.BringToFront()
    End Sub


#End Region


    Private Sub TextCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCliente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonBuscar_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        TextCliente.Clear()
    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If String.IsNullOrEmpty(TextCliente.Text) Then
                    MessageBox.Show("Debe rellenar el campo 'Cliente'")
                    Exit Sub
                Else
                    command.CommandText = "select nombre as Cliente FROM Cliente WHERE nombre LIKE '%'+@nombre+'%'"
                    command.Parameters.AddWithValue("@nombre", TextCliente.Text)
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
                    DataGridViewBusqueda.BeginEdit(False)
                    DataGridViewBusqueda.Columns(0).Width = 80
                    DataGridViewBusqueda.Focus()

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    MessageBox.Show("No se encontro ningun cliente.")
                    da2.Dispose()
                End If


            End Using
        End Using
    End Sub

    Private Sub DataGridViewBusqueda_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewBusqueda.CellPainting
        TextCliente.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
    End Sub

    Private Sub BotonAgregarCliente_Click(sender As Object, e As EventArgs) Handles BotonAgregarCliente.Click
        If String.IsNullOrEmpty(TextCliente.Text) Then
            MessageBox.Show("Debe rellenar el campo 'Cliente'")
            Exit Sub
        Else
            cliente.Text = TextCliente.Text
            Dim userModel As New UserModel()
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()

                    command.Connection = connection
                    command.CommandText = "SELECT p.codigo as Codigo,p.descripcion as Descripcion,p.stockPeru as Stock,p.acopio as Acopio 
                                           FROM acopio a INNER JOIN Producto p ON a.codProd=p.codigo
                                           WHERE a.codCliente=@nombre"
                    command.Parameters.AddWithValue("@nombre", TextCliente.Text)
                    command.CommandType = CommandType.Text

                    Dim da2 As New SqlDataAdapter(command)
                    Dim tabla As New DataTable

                    If da2.Fill(tabla) <> 0 Then

                        DataGridViewProductos.Columns.Clear()
                        Dim db As New BindingSource
                        db.DataSource = tabla
                        DataGridViewProductos.DataSource = db
                        da2.Dispose()
                        DataGridViewProductos.Focus()

                    Else
                        DataGridViewProductos.Columns.Clear()
                        MessageBox.Show("No se encontro ningun producto acopiado para este cliente.")
                        da2.Dispose()
                    End If


                End Using
            End Using
        End If
    End Sub

    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewBusqueda.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonAgregarCliente_Click(sender, e)
        End Select
    End Sub

    Private Sub DataGridViewBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewBusqueda.DoubleClick
        BotonAgregarCliente_Click(sender, e)
    End Sub

    Private Sub DataGridViewProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewProductos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCant.Clear()
                TextCant.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextCant_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCant.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonAgregar_Click(sender, e)
                e.SuppressKeyPress = True

        End Select
        If e.KeyCode = 190 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BotonAgregar_Click(sender As Object, e As EventArgs) Handles BotonAgregar.Click

        DataGridViewVenta.Rows.Add(DataGridViewProductos.CurrentRow.Cells(0).Value.ToString(), DataGridViewProductos.CurrentRow.Cells(1).Value.ToString(), TextCant.Text.Trim())
        DataGridViewVenta.ColumnHeadersVisible = True
        TextCant.Clear()

    End Sub

    Private Sub BotonConfirmar_Click(sender As Object, e As EventArgs) Handles BotonConfirmar.Click
        Dim codigoProd As String
        Dim cantidad As Double

        Dim userModel As New UserModel()
        Dim valid As Boolean

        For i As Integer = 0 To DataGridViewVenta.Rows.Count - 1
            codigoProd = DataGridViewVenta.Rows(i).Cells(0).Value.ToString
            cantidad = DataGridViewVenta.Rows(i).Cells(2).Value

            valid = userModel.BajarProductosDeStockAndAcopio(codigoProd, cantidad, TextCliente.Text)


            If valid = False Then
                MessageBox.Show("Error al retirar los productos" + vbNewLine + "Por favor, intente nuevamente.")
            End If

        Next
        DataGridViewBusqueda.Columns.Clear()
        DataGridViewVenta.Rows.Clear()
        DataGridViewVenta.ColumnHeadersVisible = False
    End Sub


End Class