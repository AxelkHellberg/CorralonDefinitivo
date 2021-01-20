<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAcopio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAcopio))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.BotonConfirmar = New System.Windows.Forms.Button()
        Me.Venta = New System.Windows.Forms.Label()
        Me.DataGridViewVenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BotonAgregar = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.TextCant = New System.Windows.Forms.TextBox()
        Me.cliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.BotonAgregarCliente = New System.Windows.Forms.Button()
        Me.DataGridViewBusqueda = New System.Windows.Forms.DataGridView()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.TextCliente = New System.Windows.Forms.TextBox()
        Me.NombreCliente = New System.Windows.Forms.Label()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "ACOPIO"
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = Global.Presentation.My.Resources.Resources.cancel
        Me.BotonClose.Location = New System.Drawing.Point(721, 9)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(751, 40)
        Me.PanelBarraTitulo.TabIndex = 11
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.BotonConfirmar)
        Me.panelContenedor.Controls.Add(Me.Venta)
        Me.panelContenedor.Controls.Add(Me.DataGridViewVenta)
        Me.panelContenedor.Controls.Add(Me.BotonAgregar)
        Me.panelContenedor.Controls.Add(Me.Cantidad)
        Me.panelContenedor.Controls.Add(Me.TextCant)
        Me.panelContenedor.Controls.Add(Me.cliente)
        Me.panelContenedor.Controls.Add(Me.Label1)
        Me.panelContenedor.Controls.Add(Me.DataGridViewProductos)
        Me.panelContenedor.Controls.Add(Me.BotonAgregarCliente)
        Me.panelContenedor.Controls.Add(Me.DataGridViewBusqueda)
        Me.panelContenedor.Controls.Add(Me.Busqueda)
        Me.panelContenedor.Controls.Add(Me.TextCliente)
        Me.panelContenedor.Controls.Add(Me.NombreCliente)
        Me.panelContenedor.Controls.Add(Me.BotonLimpiar)
        Me.panelContenedor.Controls.Add(Me.BotonBuscar)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelContenedor.Location = New System.Drawing.Point(0, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(751, 385)
        Me.panelContenedor.TabIndex = 12
        '
        'BotonConfirmar
        '
        Me.BotonConfirmar.FlatAppearance.BorderSize = 0
        Me.BotonConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonConfirmar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonConfirmar.Image = Global.Presentation.My.Resources.Resources.payment1
        Me.BotonConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonConfirmar.Location = New System.Drawing.Point(609, 319)
        Me.BotonConfirmar.Name = "BotonConfirmar"
        Me.BotonConfirmar.Size = New System.Drawing.Size(140, 43)
        Me.BotonConfirmar.TabIndex = 72
        Me.BotonConfirmar.Text = "Confirmar"
        Me.BotonConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonConfirmar.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.Venta.AutoSize = True
        Me.Venta.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Venta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Venta.Location = New System.Drawing.Point(208, 195)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(211, 24)
        Me.Venta.TabIndex = 71
        Me.Venta.Text = "Retiro de productos"
        '
        'DataGridViewVenta
        '
        Me.DataGridViewVenta.AllowUserToAddRows = False
        Me.DataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVenta.ColumnHeadersHeight = 30
        Me.DataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewVenta.ColumnHeadersVisible = False
        Me.DataGridViewVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewVenta.EnableHeadersVisualStyles = False
        Me.DataGridViewVenta.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewVenta.Location = New System.Drawing.Point(35, 222)
        Me.DataGridViewVenta.Name = "DataGridViewVenta"
        Me.DataGridViewVenta.ReadOnly = True
        Me.DataGridViewVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewVenta.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewVenta.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVenta.Size = New System.Drawing.Size(568, 140)
        Me.DataGridViewVenta.TabIndex = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad a retirar"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'BotonAgregar
        '
        Me.BotonAgregar.FlatAppearance.BorderSize = 0
        Me.BotonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAgregar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAgregar.Image = Global.Presentation.My.Resources.Resources.logout__1_1
        Me.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAgregar.Location = New System.Drawing.Point(439, 12)
        Me.BotonAgregar.Name = "BotonAgregar"
        Me.BotonAgregar.Size = New System.Drawing.Size(104, 43)
        Me.BotonAgregar.TabIndex = 69
        Me.BotonAgregar.Text = "Agregar"
        Me.BotonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonAgregar.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Cantidad.Location = New System.Drawing.Point(353, 10)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(64, 17)
        Me.Cantidad.TabIndex = 68
        Me.Cantidad.Text = "Cantidad"
        '
        'TextCant
        '
        Me.TextCant.Location = New System.Drawing.Point(356, 30)
        Me.TextCant.Name = "TextCant"
        Me.TextCant.Size = New System.Drawing.Size(63, 20)
        Me.TextCant.TabIndex = 67
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.cliente.Location = New System.Drawing.Point(600, 57)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(0, 24)
        Me.cliente.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(352, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 24)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Todos los productos de "
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AllowUserToAddRows = False
        Me.DataGridViewProductos.AllowUserToDeleteRows = False
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewProductos.ColumnHeadersHeight = 30
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewProductos.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewProductos.EnableHeadersVisualStyles = False
        Me.DataGridViewProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewProductos.Location = New System.Drawing.Point(345, 84)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.ReadOnly = True
        Me.DataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewProductos.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewProductos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProductos.Size = New System.Drawing.Size(380, 112)
        Me.DataGridViewProductos.TabIndex = 64
        '
        'BotonAgregarCliente
        '
        Me.BotonAgregarCliente.FlatAppearance.BorderSize = 0
        Me.BotonAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAgregarCliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAgregarCliente.Image = CType(resources.GetObject("BotonAgregarCliente.Image"), System.Drawing.Image)
        Me.BotonAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAgregarCliente.Location = New System.Drawing.Point(287, 114)
        Me.BotonAgregarCliente.Name = "BotonAgregarCliente"
        Me.BotonAgregarCliente.Size = New System.Drawing.Size(45, 43)
        Me.BotonAgregarCliente.TabIndex = 63
        Me.BotonAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonAgregarCliente.UseVisualStyleBackColor = True
        '
        'DataGridViewBusqueda
        '
        Me.DataGridViewBusqueda.AllowUserToAddRows = False
        Me.DataGridViewBusqueda.AllowUserToDeleteRows = False
        Me.DataGridViewBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewBusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewBusqueda.ColumnHeadersHeight = 30
        Me.DataGridViewBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBusqueda.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewBusqueda.EnableHeadersVisualStyles = False
        Me.DataGridViewBusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewBusqueda.Location = New System.Drawing.Point(35, 84)
        Me.DataGridViewBusqueda.Name = "DataGridViewBusqueda"
        Me.DataGridViewBusqueda.ReadOnly = True
        Me.DataGridViewBusqueda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewBusqueda.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBusqueda.Size = New System.Drawing.Size(231, 112)
        Me.DataGridViewBusqueda.TabIndex = 61
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Busqueda.Location = New System.Drawing.Point(154, 57)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(112, 24)
        Me.Busqueda.TabIndex = 62
        Me.Busqueda.Text = "Busqueda"
        '
        'TextCliente
        '
        Me.TextCliente.Location = New System.Drawing.Point(35, 30)
        Me.TextCliente.Name = "TextCliente"
        Me.TextCliente.Size = New System.Drawing.Size(206, 20)
        Me.TextCliente.TabIndex = 57
        '
        'NombreCliente
        '
        Me.NombreCliente.AutoSize = True
        Me.NombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreCliente.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NombreCliente.Location = New System.Drawing.Point(32, 10)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(51, 17)
        Me.NombreCliente.TabIndex = 58
        Me.NombreCliente.Text = "Cliente"
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.FlatAppearance.BorderSize = 0
        Me.BotonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonLimpiar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonLimpiar.Location = New System.Drawing.Point(100, 56)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(48, 20)
        Me.BotonLimpiar.TabIndex = 60
        Me.BotonLimpiar.Text = "Limpiar"
        Me.BotonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonLimpiar.UseVisualStyleBackColor = True
        '
        'BotonBuscar
        '
        Me.BotonBuscar.FlatAppearance.BorderSize = 0
        Me.BotonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBuscar.Location = New System.Drawing.Point(35, 56)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(48, 20)
        Me.BotonBuscar.TabIndex = 59
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'FormAcopio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 425)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Name = "FormAcopio"
        Me.Text = "FormAcopio"
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents DataGridViewBusqueda As DataGridView
    Friend WithEvents Busqueda As Label
    Friend WithEvents TextCliente As TextBox
    Friend WithEvents NombreCliente As Label
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents cliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents BotonAgregarCliente As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents TextCant As TextBox
    Friend WithEvents BotonAgregar As Button
    Friend WithEvents Venta As Label
    Friend WithEvents DataGridViewVenta As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BotonConfirmar As Button
End Class
