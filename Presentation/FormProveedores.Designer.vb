<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProveedores))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProveedorSelect = New System.Windows.Forms.Label()
        Me.BotonPagar = New System.Windows.Forms.Button()
        Me.TextBanco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextTesoro = New System.Windows.Forms.TextBox()
        Me.TextCaja = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalNum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BotonAgregarProveedor = New System.Windows.Forms.Button()
        Me.DataGridViewBusqueda = New System.Windows.Forms.DataGridView()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.TextProveedor = New System.Windows.Forms.TextBox()
        Me.NombreProveedor = New System.Windows.Forms.Label()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Proveedores = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ProveedorSelect)
        Me.Panel1.Controls.Add(Me.BotonPagar)
        Me.Panel1.Controls.Add(Me.TextBanco)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextTesoro)
        Me.Panel1.Controls.Add(Me.TextCaja)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TotalNum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BotonAgregarProveedor)
        Me.Panel1.Controls.Add(Me.DataGridViewBusqueda)
        Me.Panel1.Controls.Add(Me.Busqueda)
        Me.Panel1.Controls.Add(Me.TextProveedor)
        Me.Panel1.Controls.Add(Me.NombreProveedor)
        Me.Panel1.Controls.Add(Me.BotonLimpiar)
        Me.Panel1.Controls.Add(Me.BotonBuscar)
        Me.Panel1.Controls.Add(Me.PanelBarraTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 340)
        Me.Panel1.TabIndex = 0
        '
        'ProveedorSelect
        '
        Me.ProveedorSelect.AutoSize = True
        Me.ProveedorSelect.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorSelect.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ProveedorSelect.Location = New System.Drawing.Point(127, 249)
        Me.ProveedorSelect.Name = "ProveedorSelect"
        Me.ProveedorSelect.Size = New System.Drawing.Size(289, 24)
        Me.ProveedorSelect.TabIndex = 87
        Me.ProveedorSelect.Text = "(sin seleccionar proveedor)"
        '
        'BotonPagar
        '
        Me.BotonPagar.FlatAppearance.BorderSize = 0
        Me.BotonPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonPagar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonPagar.Image = Global.Presentation.My.Resources.Resources.pngegg__2_
        Me.BotonPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonPagar.Location = New System.Drawing.Point(457, 280)
        Me.BotonPagar.Name = "BotonPagar"
        Me.BotonPagar.Size = New System.Drawing.Size(96, 43)
        Me.BotonPagar.TabIndex = 86
        Me.BotonPagar.Text = "Pagar"
        Me.BotonPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonPagar.UseVisualStyleBackColor = True
        '
        'TextBanco
        '
        Me.TextBanco.Location = New System.Drawing.Point(379, 298)
        Me.TextBanco.Name = "TextBanco"
        Me.TextBanco.Size = New System.Drawing.Size(45, 20)
        Me.TextBanco.TabIndex = 85
        Me.TextBanco.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label7.Location = New System.Drawing.Point(378, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Banco"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Location = New System.Drawing.Point(327, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Tesoro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(276, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Caja"
        '
        'TextTesoro
        '
        Me.TextTesoro.Location = New System.Drawing.Point(330, 298)
        Me.TextTesoro.Name = "TextTesoro"
        Me.TextTesoro.Size = New System.Drawing.Size(43, 20)
        Me.TextTesoro.TabIndex = 81
        Me.TextTesoro.Text = "0"
        '
        'TextCaja
        '
        Me.TextCaja.Location = New System.Drawing.Point(276, 298)
        Me.TextCaja.Name = "TextCaja"
        Me.TextCaja.Size = New System.Drawing.Size(48, 20)
        Me.TextCaja.TabIndex = 80
        Me.TextCaja.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Location = New System.Drawing.Point(7, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 34)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "TOTAL  $"
        '
        'TotalNum
        '
        Me.TotalNum.AutoSize = True
        Me.TotalNum.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.TotalNum.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalNum.Location = New System.Drawing.Point(152, 289)
        Me.TotalNum.Name = "TotalNum"
        Me.TotalNum.Size = New System.Drawing.Size(70, 34)
        Me.TotalNum.TabIndex = 78
        Me.TotalNum.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(12, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 24)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "PAGAR A:"
        '
        'BotonAgregarProveedor
        '
        Me.BotonAgregarProveedor.FlatAppearance.BorderSize = 0
        Me.BotonAgregarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonAgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAgregarProveedor.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgregarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAgregarProveedor.Image = CType(resources.GetObject("BotonAgregarProveedor.Image"), System.Drawing.Image)
        Me.BotonAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAgregarProveedor.Location = New System.Drawing.Point(257, 65)
        Me.BotonAgregarProveedor.Name = "BotonAgregarProveedor"
        Me.BotonAgregarProveedor.Size = New System.Drawing.Size(142, 43)
        Me.BotonAgregarProveedor.TabIndex = 64
        Me.BotonAgregarProveedor.Text = "Agregar proveedor"
        Me.BotonAgregarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonAgregarProveedor.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBusqueda.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewBusqueda.EnableHeadersVisualStyles = False
        Me.DataGridViewBusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewBusqueda.Location = New System.Drawing.Point(34, 134)
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
        Me.DataGridViewBusqueda.Size = New System.Drawing.Size(530, 112)
        Me.DataGridViewBusqueda.TabIndex = 62
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Busqueda.Location = New System.Drawing.Point(232, 107)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(112, 24)
        Me.Busqueda.TabIndex = 63
        Me.Busqueda.Text = "Busqueda"
        '
        'TextProveedor
        '
        Me.TextProveedor.Location = New System.Drawing.Point(34, 80)
        Me.TextProveedor.Name = "TextProveedor"
        Me.TextProveedor.Size = New System.Drawing.Size(206, 20)
        Me.TextProveedor.TabIndex = 58
        '
        'NombreProveedor
        '
        Me.NombreProveedor.AutoSize = True
        Me.NombreProveedor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProveedor.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NombreProveedor.Location = New System.Drawing.Point(31, 60)
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.Size = New System.Drawing.Size(71, 17)
        Me.NombreProveedor.TabIndex = 59
        Me.NombreProveedor.Text = "Proveedor"
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
        Me.BotonLimpiar.Location = New System.Drawing.Point(99, 106)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(48, 20)
        Me.BotonLimpiar.TabIndex = 61
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
        Me.BotonBuscar.Location = New System.Drawing.Point(34, 106)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(48, 20)
        Me.BotonBuscar.TabIndex = 60
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Proveedores)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(593, 40)
        Me.PanelBarraTitulo.TabIndex = 13
        '
        'Proveedores
        '
        Me.Proveedores.AutoSize = True
        Me.Proveedores.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedores.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Proveedores.Location = New System.Drawing.Point(12, 9)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(158, 24)
        Me.Proveedores.TabIndex = 76
        Me.Proveedores.Text = "PROVEEDORES"
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = CType(resources.GetObject("BotonClose.Image"), System.Drawing.Image)
        Me.BotonClose.Location = New System.Drawing.Point(567, 10)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'FormProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 340)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProveedores"
        Me.Text = "FormProveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents Proveedores As Label
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents BotonAgregarProveedor As Button
    Friend WithEvents DataGridViewBusqueda As DataGridView
    Friend WithEvents Busqueda As Label
    Friend WithEvents TextProveedor As TextBox
    Friend WithEvents NombreProveedor As Label
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBanco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextTesoro As TextBox
    Friend WithEvents TextCaja As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalNum As Label
    Friend WithEvents BotonPagar As Button
    Friend WithEvents ProveedorSelect As Label
End Class
