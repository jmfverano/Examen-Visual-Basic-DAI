<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AltaCaballo = New System.Windows.Forms.ToolStripButton()
        Me.AltaCliente = New System.Windows.Forms.ToolStripButton()
        Me.AltaGanadería = New System.Windows.Forms.ToolStripButton()
        Me.AltaVenta = New System.Windows.Forms.ToolStripButton()
        Me.ConsultaVenta = New System.Windows.Forms.ToolStripButton()
        Me.EliminaVenta = New System.Windows.Forms.ToolStripButton()
        Me.ModificaVenta = New System.Windows.Forms.ToolStripButton()
        Me.InformeVentas = New System.Windows.Forms.ToolStripButton()
        Me.Cliente = New System.Windows.Forms.GroupBox()
        Me.cEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cDni = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ganadería = New System.Windows.Forms.GroupBox()
        Me.gEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gDireccion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gFax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gPropietario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gCodigo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Venta = New System.Windows.Forms.GroupBox()
        Me.vNoPagado = New System.Windows.Forms.RadioButton()
        Me.vPagado = New System.Windows.Forms.RadioButton()
        Me.vPrecio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.vFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.vCodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Caballo = New System.Windows.Forms.GroupBox()
        Me.cbNoVendido = New System.Windows.Forms.RadioButton()
        Me.cbVendido = New System.Windows.Forms.RadioButton()
        Me.cbGanaderia = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbDisciplina = New System.Windows.Forms.ComboBox()
        Me.cbCapa = New System.Windows.Forms.ComboBox()
        Me.cbRaza = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbEdad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbNombre = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbCodigo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.Cliente.SuspendLayout()
        Me.Ganadería.SuspendLayout()
        Me.Venta.SuspendLayout()
        Me.Caballo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(75, 75)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaCaballo, Me.AltaCliente, Me.AltaGanadería, Me.AltaVenta, Me.ConsultaVenta, Me.EliminaVenta, Me.ModificaVenta, Me.InformeVentas})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(725, 97)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AltaCaballo
        '
        Me.AltaCaballo.Image = CType(resources.GetObject("AltaCaballo.Image"), System.Drawing.Image)
        Me.AltaCaballo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AltaCaballo.Name = "AltaCaballo"
        Me.AltaCaballo.Size = New System.Drawing.Size(79, 94)
        Me.AltaCaballo.Text = "Alta Caballo"
        Me.AltaCaballo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AltaCaballo.ToolTipText = "Alta Caballo"
        '
        'AltaCliente
        '
        Me.AltaCliente.Image = CType(resources.GetObject("AltaCliente.Image"), System.Drawing.Image)
        Me.AltaCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AltaCliente.Name = "AltaCliente"
        Me.AltaCliente.Size = New System.Drawing.Size(79, 94)
        Me.AltaCliente.Text = "Alta Cliente"
        Me.AltaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AltaGanadería
        '
        Me.AltaGanadería.Image = CType(resources.GetObject("AltaGanadería.Image"), System.Drawing.Image)
        Me.AltaGanadería.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AltaGanadería.Name = "AltaGanadería"
        Me.AltaGanadería.Size = New System.Drawing.Size(88, 94)
        Me.AltaGanadería.Text = "Alta Ganaderia"
        Me.AltaGanadería.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AltaVenta
        '
        Me.AltaVenta.Image = CType(resources.GetObject("AltaVenta.Image"), System.Drawing.Image)
        Me.AltaVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AltaVenta.Name = "AltaVenta"
        Me.AltaVenta.Size = New System.Drawing.Size(79, 94)
        Me.AltaVenta.Text = "Alta Venta"
        Me.AltaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ConsultaVenta
        '
        Me.ConsultaVenta.Image = CType(resources.GetObject("ConsultaVenta.Image"), System.Drawing.Image)
        Me.ConsultaVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConsultaVenta.Name = "ConsultaVenta"
        Me.ConsultaVenta.Size = New System.Drawing.Size(91, 94)
        Me.ConsultaVenta.Text = "Consulta Venta"
        Me.ConsultaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EliminaVenta
        '
        Me.EliminaVenta.Image = CType(resources.GetObject("EliminaVenta.Image"), System.Drawing.Image)
        Me.EliminaVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminaVenta.Name = "EliminaVenta"
        Me.EliminaVenta.Size = New System.Drawing.Size(87, 94)
        Me.EliminaVenta.Text = "Eliminar Venta"
        Me.EliminaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ModificaVenta
        '
        Me.ModificaVenta.Image = CType(resources.GetObject("ModificaVenta.Image"), System.Drawing.Image)
        Me.ModificaVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ModificaVenta.Name = "ModificaVenta"
        Me.ModificaVenta.Size = New System.Drawing.Size(95, 94)
        Me.ModificaVenta.Text = "Modificar Venta"
        Me.ModificaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InformeVentas
        '
        Me.InformeVentas.Image = CType(resources.GetObject("InformeVentas.Image"), System.Drawing.Image)
        Me.InformeVentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InformeVentas.Name = "InformeVentas"
        Me.InformeVentas.Size = New System.Drawing.Size(91, 94)
        Me.InformeVentas.Text = "Informe Ventas"
        Me.InformeVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Cliente
        '
        Me.Cliente.Controls.Add(Me.cEmail)
        Me.Cliente.Controls.Add(Me.Label6)
        Me.Cliente.Controls.Add(Me.cTelefono)
        Me.Cliente.Controls.Add(Me.Label5)
        Me.Cliente.Controls.Add(Me.cDireccion)
        Me.Cliente.Controls.Add(Me.Label4)
        Me.Cliente.Controls.Add(Me.cApellidos)
        Me.Cliente.Controls.Add(Me.Label3)
        Me.Cliente.Controls.Add(Me.cNombre)
        Me.Cliente.Controls.Add(Me.Label2)
        Me.Cliente.Controls.Add(Me.cDni)
        Me.Cliente.Controls.Add(Me.Label1)
        Me.Cliente.Location = New System.Drawing.Point(12, 111)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(328, 196)
        Me.Cliente.TabIndex = 1
        Me.Cliente.TabStop = False
        Me.Cliente.Text = "Cliente"
        '
        'cEmail
        '
        Me.cEmail.Location = New System.Drawing.Point(73, 155)
        Me.cEmail.Name = "cEmail"
        Me.cEmail.Size = New System.Drawing.Size(227, 20)
        Me.cEmail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'cTelefono
        '
        Me.cTelefono.Location = New System.Drawing.Point(73, 129)
        Me.cTelefono.Name = "cTelefono"
        Me.cTelefono.Size = New System.Drawing.Size(227, 20)
        Me.cTelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teléfono"
        '
        'cDireccion
        '
        Me.cDireccion.Location = New System.Drawing.Point(73, 103)
        Me.cDireccion.Name = "cDireccion"
        Me.cDireccion.Size = New System.Drawing.Size(227, 20)
        Me.cDireccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección"
        '
        'cApellidos
        '
        Me.cApellidos.Location = New System.Drawing.Point(73, 77)
        Me.cApellidos.Name = "cApellidos"
        Me.cApellidos.Size = New System.Drawing.Size(227, 20)
        Me.cApellidos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos"
        '
        'cNombre
        '
        Me.cNombre.Location = New System.Drawing.Point(73, 51)
        Me.cNombre.Name = "cNombre"
        Me.cNombre.Size = New System.Drawing.Size(227, 20)
        Me.cNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'cDni
        '
        Me.cDni.FormattingEnabled = True
        Me.cDni.Location = New System.Drawing.Point(73, 24)
        Me.cDni.Name = "cDni"
        Me.cDni.Size = New System.Drawing.Size(227, 21)
        Me.cDni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'Ganadería
        '
        Me.Ganadería.Controls.Add(Me.gEmail)
        Me.Ganadería.Controls.Add(Me.Label13)
        Me.Ganadería.Controls.Add(Me.gDireccion)
        Me.Ganadería.Controls.Add(Me.Label12)
        Me.Ganadería.Controls.Add(Me.gFax)
        Me.Ganadería.Controls.Add(Me.Label7)
        Me.Ganadería.Controls.Add(Me.gTelefono)
        Me.Ganadería.Controls.Add(Me.Label8)
        Me.Ganadería.Controls.Add(Me.gPropietario)
        Me.Ganadería.Controls.Add(Me.Label9)
        Me.Ganadería.Controls.Add(Me.gNombre)
        Me.Ganadería.Controls.Add(Me.Label10)
        Me.Ganadería.Controls.Add(Me.gCodigo)
        Me.Ganadería.Controls.Add(Me.Label11)
        Me.Ganadería.Location = New System.Drawing.Point(12, 323)
        Me.Ganadería.Name = "Ganadería"
        Me.Ganadería.Size = New System.Drawing.Size(328, 263)
        Me.Ganadería.TabIndex = 2
        Me.Ganadería.TabStop = False
        Me.Ganadería.Text = "Ganadería"
        '
        'gEmail
        '
        Me.gEmail.Location = New System.Drawing.Point(73, 185)
        Me.gEmail.Name = "gEmail"
        Me.gEmail.Size = New System.Drawing.Size(227, 20)
        Me.gEmail.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Email"
        '
        'gDireccion
        '
        Me.gDireccion.Location = New System.Drawing.Point(73, 107)
        Me.gDireccion.Name = "gDireccion"
        Me.gDireccion.Size = New System.Drawing.Size(227, 20)
        Me.gDireccion.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Dirección"
        '
        'gFax
        '
        Me.gFax.Location = New System.Drawing.Point(73, 159)
        Me.gFax.Name = "gFax"
        Me.gFax.Size = New System.Drawing.Size(227, 20)
        Me.gFax.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fax"
        '
        'gTelefono
        '
        Me.gTelefono.Location = New System.Drawing.Point(73, 133)
        Me.gTelefono.Name = "gTelefono"
        Me.gTelefono.Size = New System.Drawing.Size(227, 20)
        Me.gTelefono.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Teléfono"
        '
        'gPropietario
        '
        Me.gPropietario.Location = New System.Drawing.Point(73, 81)
        Me.gPropietario.Name = "gPropietario"
        Me.gPropietario.Size = New System.Drawing.Size(227, 20)
        Me.gPropietario.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Propietario"
        '
        'gNombre
        '
        Me.gNombre.Location = New System.Drawing.Point(73, 55)
        Me.gNombre.Name = "gNombre"
        Me.gNombre.Size = New System.Drawing.Size(227, 20)
        Me.gNombre.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nombre"
        '
        'gCodigo
        '
        Me.gCodigo.Location = New System.Drawing.Point(73, 29)
        Me.gCodigo.Name = "gCodigo"
        Me.gCodigo.Size = New System.Drawing.Size(227, 20)
        Me.gCodigo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Código"
        '
        'Venta
        '
        Me.Venta.Controls.Add(Me.vNoPagado)
        Me.Venta.Controls.Add(Me.vPagado)
        Me.Venta.Controls.Add(Me.vPrecio)
        Me.Venta.Controls.Add(Me.Label16)
        Me.Venta.Controls.Add(Me.vFecha)
        Me.Venta.Controls.Add(Me.Label15)
        Me.Venta.Controls.Add(Me.vCodigo)
        Me.Venta.Controls.Add(Me.Label14)
        Me.Venta.Location = New System.Drawing.Point(355, 111)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(337, 196)
        Me.Venta.TabIndex = 3
        Me.Venta.TabStop = False
        Me.Venta.Text = "Venta"
        '
        'vNoPagado
        '
        Me.vNoPagado.AutoSize = True
        Me.vNoPagado.Location = New System.Drawing.Point(220, 141)
        Me.vNoPagado.Name = "vNoPagado"
        Me.vNoPagado.Size = New System.Drawing.Size(79, 17)
        Me.vNoPagado.TabIndex = 21
        Me.vNoPagado.TabStop = True
        Me.vNoPagado.Text = "No Pagado"
        Me.vNoPagado.UseVisualStyleBackColor = True
        '
        'vPagado
        '
        Me.vPagado.AutoSize = True
        Me.vPagado.Location = New System.Drawing.Point(29, 141)
        Me.vPagado.Name = "vPagado"
        Me.vPagado.Size = New System.Drawing.Size(62, 17)
        Me.vPagado.TabIndex = 20
        Me.vPagado.TabStop = True
        Me.vPagado.Text = "Pagado"
        Me.vPagado.UseVisualStyleBackColor = True
        '
        'vPrecio
        '
        Me.vPrecio.Location = New System.Drawing.Point(83, 89)
        Me.vPrecio.Name = "vPrecio"
        Me.vPrecio.Size = New System.Drawing.Size(227, 20)
        Me.vPrecio.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Precio"
        '
        'vFecha
        '
        Me.vFecha.Location = New System.Drawing.Point(83, 54)
        Me.vFecha.Name = "vFecha"
        Me.vFecha.Size = New System.Drawing.Size(227, 20)
        Me.vFecha.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Fecha"
        '
        'vCodigo
        '
        Me.vCodigo.Location = New System.Drawing.Point(83, 24)
        Me.vCodigo.Name = "vCodigo"
        Me.vCodigo.Size = New System.Drawing.Size(227, 20)
        Me.vCodigo.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Código"
        '
        'Caballo
        '
        Me.Caballo.Controls.Add(Me.cbNoVendido)
        Me.Caballo.Controls.Add(Me.cbVendido)
        Me.Caballo.Controls.Add(Me.cbGanaderia)
        Me.Caballo.Controls.Add(Me.Label24)
        Me.Caballo.Controls.Add(Me.cbDisciplina)
        Me.Caballo.Controls.Add(Me.cbCapa)
        Me.Caballo.Controls.Add(Me.cbRaza)
        Me.Caballo.Controls.Add(Me.cbTipo)
        Me.Caballo.Controls.Add(Me.Label23)
        Me.Caballo.Controls.Add(Me.Label22)
        Me.Caballo.Controls.Add(Me.Label21)
        Me.Caballo.Controls.Add(Me.Label20)
        Me.Caballo.Controls.Add(Me.cbEdad)
        Me.Caballo.Controls.Add(Me.Label19)
        Me.Caballo.Controls.Add(Me.cbNombre)
        Me.Caballo.Controls.Add(Me.Label18)
        Me.Caballo.Controls.Add(Me.cbCodigo)
        Me.Caballo.Controls.Add(Me.Label17)
        Me.Caballo.Location = New System.Drawing.Point(355, 323)
        Me.Caballo.Name = "Caballo"
        Me.Caballo.Size = New System.Drawing.Size(337, 263)
        Me.Caballo.TabIndex = 4
        Me.Caballo.TabStop = False
        Me.Caballo.Text = "Caballo"
        '
        'cbNoVendido
        '
        Me.cbNoVendido.AutoSize = True
        Me.cbNoVendido.Location = New System.Drawing.Point(222, 234)
        Me.cbNoVendido.Name = "cbNoVendido"
        Me.cbNoVendido.Size = New System.Drawing.Size(73, 17)
        Me.cbNoVendido.TabIndex = 34
        Me.cbNoVendido.TabStop = True
        Me.cbNoVendido.Text = "Pendiente"
        Me.cbNoVendido.UseVisualStyleBackColor = True
        '
        'cbVendido
        '
        Me.cbVendido.AutoSize = True
        Me.cbVendido.Location = New System.Drawing.Point(31, 234)
        Me.cbVendido.Name = "cbVendido"
        Me.cbVendido.Size = New System.Drawing.Size(64, 17)
        Me.cbVendido.TabIndex = 33
        Me.cbVendido.TabStop = True
        Me.cbVendido.Text = "Vendido"
        Me.cbVendido.UseVisualStyleBackColor = True
        '
        'cbGanaderia
        '
        Me.cbGanaderia.FormattingEnabled = True
        Me.cbGanaderia.Location = New System.Drawing.Point(84, 202)
        Me.cbGanaderia.Name = "cbGanaderia"
        Me.cbGanaderia.Size = New System.Drawing.Size(227, 21)
        Me.cbGanaderia.TabIndex = 32
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(26, 205)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 13)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Ganaderia"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.Items.AddRange(New Object() {"carreras", "crianza", "doma clásica", "doma vaquera", "paseo", "salto", "polo"})
        Me.cbDisciplina.Location = New System.Drawing.Point(84, 175)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(227, 21)
        Me.cbDisciplina.TabIndex = 30
        '
        'cbCapa
        '
        Me.cbCapa.FormattingEnabled = True
        Me.cbCapa.Items.AddRange(New Object() {"alazán", "blanco", "café con leche", "castaño", "gris", "negro", "tordo"})
        Me.cbCapa.Location = New System.Drawing.Point(83, 149)
        Me.cbCapa.Name = "cbCapa"
        Me.cbCapa.Size = New System.Drawing.Size(227, 21)
        Me.cbCapa.TabIndex = 29
        '
        'cbRaza
        '
        Me.cbRaza.FormattingEnabled = True
        Me.cbRaza.Items.AddRange(New Object() {"pura raza española", "pura raza árabe", "andaluz", "bretón", "criollo", "cruzado", "palomino"})
        Me.cbRaza.Location = New System.Drawing.Point(83, 123)
        Me.cbRaza.Name = "cbRaza"
        Me.cbRaza.Size = New System.Drawing.Size(227, 21)
        Me.cbRaza.TabIndex = 28
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"semental", "capado", "yegua", "potro", "potra"})
        Me.cbTipo.Location = New System.Drawing.Point(83, 97)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(227, 21)
        Me.cbTipo.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 178)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Disciplina"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Capa"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 126)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Raza"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Tipo"
        '
        'cbEdad
        '
        Me.cbEdad.Location = New System.Drawing.Point(83, 71)
        Me.cbEdad.Name = "cbEdad"
        Me.cbEdad.Size = New System.Drawing.Size(227, 20)
        Me.cbEdad.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(26, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Edad"
        '
        'cbNombre
        '
        Me.cbNombre.Location = New System.Drawing.Point(83, 45)
        Me.cbNombre.Name = "cbNombre"
        Me.cbNombre.Size = New System.Drawing.Size(227, 20)
        Me.cbNombre.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Nombre"
        '
        'cbCodigo
        '
        Me.cbCodigo.FormattingEnabled = True
        Me.cbCodigo.Location = New System.Drawing.Point(83, 18)
        Me.cbCodigo.Name = "cbCodigo"
        Me.cbCodigo.Size = New System.Drawing.Size(227, 21)
        Me.cbCodigo.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(26, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Código"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 598)
        Me.Controls.Add(Me.Caballo)
        Me.Controls.Add(Me.Venta)
        Me.Controls.Add(Me.Ganadería)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Hermanos Valenciaga Heredia S/A"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Cliente.ResumeLayout(False)
        Me.Cliente.PerformLayout()
        Me.Ganadería.ResumeLayout(False)
        Me.Ganadería.PerformLayout()
        Me.Venta.ResumeLayout(False)
        Me.Venta.PerformLayout()
        Me.Caballo.ResumeLayout(False)
        Me.Caballo.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents AltaCaballo As System.Windows.Forms.ToolStripButton
    Friend WithEvents AltaCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents AltaGanadería As System.Windows.Forms.ToolStripButton
    Friend WithEvents AltaVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConsultaVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents EliminaVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ModificaVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents InformeVentas As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents cEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cDni As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ganadería As System.Windows.Forms.GroupBox
    Friend WithEvents gEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gFax As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Venta As System.Windows.Forms.GroupBox
    Friend WithEvents vNoPagado As System.Windows.Forms.RadioButton
    Friend WithEvents vPagado As System.Windows.Forms.RadioButton
    Friend WithEvents vPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents vFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents vCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Caballo As System.Windows.Forms.GroupBox
    Friend WithEvents cbNoVendido As System.Windows.Forms.RadioButton
    Friend WithEvents cbVendido As System.Windows.Forms.RadioButton
    Friend WithEvents cbGanaderia As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents cbCapa As System.Windows.Forms.ComboBox
    Friend WithEvents cbRaza As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
