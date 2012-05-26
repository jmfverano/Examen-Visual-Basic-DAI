Public Class Form1
    'Crea atributo encargado de conectar con la base de datos.
    Public Shared miConexion As New System.Data.OleDb.OleDbConnection
    'Crea el comando para almacenara las consultas en la base de datos.
    Dim comando As New OleDb.OleDbCommand
    'Crea el lector para las consultas select...
    Dim miLector As OleDb.OleDbDataReader
    'Conjunto de datos donde se carga la base de datos --> dataset
    Dim conjuntoDatos As New DataSet
    'Crea el adaptador para conectarse con la base de datos..
    Dim adaptador As New OleDb.OleDbDataAdapter
    'Este atributo controlara cuando se a pulsado el boton alta cliente, estando false para la primera vez y true para la segunda.
    Dim AltaClienteYaPulsado As Boolean = False
    'Este atributo controlara cuando se a pulsado el boton alta caballo, estando false para la primera vez y true para la segunda.
    Dim AltaCaballoYaPulsado As Boolean = False
    'Este atributo controlara cuando se a pulsado el boton alta Ganaderia, estando false para la primera vez y true para la segunda.
    Dim AltaGanaderiaYaPulsado As Boolean = False
    'Este atributo controlara cuando se a pulsado el boton alta Venta, estando false para la primera vez y true para la segunda.
    Dim AltaVentaYaPulsado As Boolean = False
    'Este atributo controlara cuando se a pulsado el boton Modifica Venta, estando false para la primera vez y true para la segunda.
    Dim ModificaYaPulsado As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            miConexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HermanosValenciaga.mdb"
            miConexion.Open()
            'Le introduce los datos de la conexión al objeto OleDbCommand
            comando.Connection = miConexion
            MsgBox("La conexión se realizo correctamente.")
            'Añade los clientes disponibles al iniciar el programa.
            Introduce_Datos_DNI_Cliente()
            'Añade los caballos que se encuentran en la base de datos a iniciar el programa.
            Introduce_Codigo_Caballos()
            'Añande las ganaderias disponibles en la base de datos al iniciar el programa.
            Introduce_Ganaderias_Para_Caballos()
            'Establece el bloqueo de los grupbox a la espera de selección de operacion
            bloqueoInicial()
        Catch ex As Exception
            MsgBox("Se genero el siguiente error... " + vbCrLf + ex.ToString)
        End Try
    End Sub
    Private Sub Introduce_Datos_DNI_Cliente()
        'Añade los DNI de los clientes disponibles a en la base de datos..
        cDni.Items.Clear()
        Try
            comando.CommandText = "Select dni from Clientes;"
            miLector = comando.ExecuteReader
            'Ahora se añade al comboBox..
            If miLector.HasRows = True Then
                While miLector.Read
                    cDni.Items.Add(miLector(0))
                End While
                miLector.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Muestra_Clientes_Segun_DNI()
        'Muestra los datos de cada cliente.
        Try
            comando.CommandText = "Select * from Clientes where dni = '" + cDni.Text + "';"
            miLector = comando.ExecuteReader
            'Ahora se añade a los TextBox
            If miLector.HasRows = True Then
                While miLector.Read
                    cNombre.Text = miLector(1)
                    cApellidos.Text = miLector(2)
                    cDireccion.Text = miLector(3)
                    cTelefono.Text = miLector(4)
                    cEmail.Text = miLector(5)
                End While
                miLector.Close()
            End If
        Catch ex As Exception
            'MsgBox("Motrar Cliente cuando termine la busqueda.")
        End Try
    End Sub
    Private Sub Introduce_Codigo_Caballos()
        'Añade los DNI de los clientes disponibles a en la base de datos..
        cbCodigo.Items.Clear()
        Try
            comando.CommandText = "Select codigoCaballo from Caballos;"
            miLector = comando.ExecuteReader
            'Ahora se añade al comboBox..
            If miLector.HasRows = True Then
                While miLector.Read
                    cbCodigo.Items.Add(miLector(0))
                End While
                miLector.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Muestra_Caballos_Segun_Codigo()
        'Muestra los datos de cada Caballo.
        Try
            comando.CommandText = "Select * from Caballos where codigoCaballo = '" + cbCodigo.Text + "';"
            miLector = comando.ExecuteReader
            'Ahora se añade a los TextBox
            If miLector.HasRows = True Then
                While miLector.Read
                    cbNombre.Text = miLector(1)
                    cbEdad.Text = miLector(2).ToString
                    cbTipo.Text = miLector(3)
                    cbRaza.Text = miLector(4)
                    cbCapa.Text = miLector(5)
                    cbDisciplina.Text = miLector(6)
                    If miLector(7).ToString = "True" Then
                        cbVendido.Checked = True
                    Else
                        cbNoVendido.Checked = True
                    End If
                    cbGanaderia.Text = miLector(8)
                End While
                miLector.Close()
            End If
        Catch ex As Exception
            'MsgBox("Motrar Caballo cuando termine la busqueda.")
        End Try
    End Sub
    Private Sub Introduce_Ganaderias_Para_Caballos()
        'Añade los datos de las ganaderias disponibles a en la base de datos..
        cbGanaderia.Items.Clear()
        Try
            comando.CommandText = "Select codigoGanaderia from Ganaderias;"
            miLector = comando.ExecuteReader
            'Ahora se añade al comboBox..
            If miLector.HasRows = True Then
                While miLector.Read
                    cbGanaderia.Items.Add(miLector(0))
                End While
                miLector.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Muestra_Ganaderia_Segun_Codigo()
        'Muestra los datos de cada cliente.
        Try
            comando.CommandText = "Select * from Ganaderias where codigoGanaderia = '" + cbGanaderia.Text + "';"
            miLector = comando.ExecuteReader
            'Ahora se añade a los TextBox
            If miLector.HasRows = True Then
                While miLector.Read
                    gCodigo.Text = miLector(0)
                    gNombre.Text = miLector(1)
                    gPropietario.Text = miLector(2)
                    gDireccion.Text = miLector(3)
                    gTelefono.Text = miLector(4)
                    gFax.Text = miLector(5)
                    gEmail.Text = miLector(6)
                End While
                miLector.Close()
            End If
        Catch ex As Exception
            'MsgBox("Motrar Ganadería cuando termine la busqueda.")
        End Try
    End Sub

    Private Sub LimpiarTodo()
        'Limpiamos todos los datos...
        cDni.Text = ""
        cNombre.Clear()
        cApellidos.Clear()
        cDireccion.Clear()
        cTelefono.Clear()
        cEmail.Clear()
        gCodigo.Clear()
        gNombre.Clear()
        gPropietario.Clear()
        gDireccion.Clear()
        gTelefono.Clear()
        gFax.Clear()
        gEmail.Clear()
        vCodigo.Clear()
        vPrecio.Clear()
        vPagado.Checked = False
        vNoPagado.Checked = False
        cbCodigo.Text = ""
        cbNombre.Clear()
        cbEdad.Clear()
        cbTipo.Text = ""
        cbRaza.Text = ""
        cbCapa.Text = ""
        cbDisciplina.Text = ""
        cbGanaderia.Text = ""
    End Sub
    Private Sub cDni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cDni.SelectedIndexChanged
        Muestra_Clientes_Segun_DNI()
    End Sub
    Private Sub cbCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCodigo.SelectedIndexChanged
        Muestra_Caballos_Segun_Codigo()
        If cbCodigo.Text <> "" Then
            Muestra_Ganaderia_Segun_Codigo()
        End If
    End Sub

    Private Sub OperacionAltaCliente()
        'Comprueba si el boton fue pulsado o por el contrario es la primera vez.
        If AltaClienteYaPulsado = False Then
            LimpiarTodo()
            BloqueoAltaCliente()
            MsgBox("Introduce el los datos..")
            AltaClienteYaPulsado = True
        ElseIf AltaClienteYaPulsado = True Then
            If esNoVacioCliente() = True Then
                Try
                    'Añade la consulta Insert seleccionada.
                    Dim miSentenciaSQL As String = "Insert Into Clientes (DNI, nombre, apellidos, direccion,telefono, email) Values ('" + cDni.Text + "','" + cNombre.Text + "','" + cApellidos.Text + "','" + cDireccion.Text + "' ,'" + cTelefono.Text + "','" + cEmail.Text + "');"
                    comando.CommandText = miSentenciaSQL
                    comando.ExecuteNonQuery()
                    MsgBox("El registro se realizo correctamente.")
                    LimpiarTodo()
                    bloqueoInicial()
                    AltaClienteYaPulsado = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Faltan datos por introducir.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub OperacionAltaCaballo()
        'Comprueba si el boton fue pulsado o por el contrario es la primera vez.
        If AltaCaballoYaPulsado = False Then
            LimpiarTodo()
            BloqueoAltaCaballo()
            MsgBox("Introduce el los datos..")
            AltaCaballoYaPulsado = True
        ElseIf AltaCaballoYaPulsado = True Then
            If esNoVacioCaballo() = True Then
                Try
                    'Añade la consulta Insert seleccionada.
                    Dim miSentenciaSQL As String
                    'Comprueba si el caballo esta vendido o no.
                    If cbVendido.Checked = True Then
                        miSentenciaSQL = "Insert Into Caballos (codigoCaballo, nombreCaballo, edad, tipo,raza, capa, disciplina, vendido, ganaderia) Values ('" + cbCodigo.Text + "','" + cbNombre.Text + "'," + cbEdad.Text + ",'" + cbTipo.Text + "' ,'" + cbRaza.Text + "','" + cbCapa.Text + "','" + cbDisciplina.Text + "', True, '" + cbGanaderia.Text + "' );"
                    Else
                        miSentenciaSQL = "Insert Into Caballos (codigoCaballo, nombreCaballo, edad, tipo,raza, capa, disciplina, vendido, ganaderia) Values ('" + cbCodigo.Text + "','" + cbNombre.Text + "'," + cbEdad.Text + ",'" + cbTipo.Text + "' ,'" + cbRaza.Text + "','" + cbCapa.Text + "','" + cbDisciplina.Text + "', False, '" + cbGanaderia.Text + "' );"
                    End If
                    comando.CommandText = miSentenciaSQL
                    comando.ExecuteNonQuery()
                    MsgBox("El registro se realizo correctamente.")
                    LimpiarTodo()
                    bloqueoInicial()
                    AltaClienteYaPulsado = False
                    Introduce_Codigo_Caballos()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Faltan datos por introducir.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub OperacionAltaGanaderia()
        'Comprueba si el boton fue pulsado o por el contrario es la primera vez.
        If AltaGanaderiaYaPulsado = False Then
            LimpiarTodo()
            BloqueoAltaGanaderia()
            MsgBox("Introduce el los datos..")
            AltaGanaderiaYaPulsado = True
        ElseIf AltaGanaderiaYaPulsado = True Then
            If esNoVacioGanaderia() = True Then
                Try
                    'Añade la consulta Insert seleccionada.
                    Dim miSentenciaSQL As String = "Insert Into Ganaderias (codigoGanaderia, nombreGanaderia, propietario, direccion,telefono, fax, email) Values ('" + gCodigo.Text + "','" + gNombre.Text + "','" + gPropietario.Text + "','" + gDireccion.Text + "' ,'" + gTelefono.Text + "','" + gFax.Text + "','" + gEmail.Text + "');"
                    comando.CommandText = miSentenciaSQL
                    comando.ExecuteNonQuery()
                    MsgBox("El registro se realizo correctamente.")
                    LimpiarTodo()
                    bloqueoInicial()
                    AltaGanaderiaYaPulsado = False
                    Introduce_Ganaderias_Para_Caballos()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Faltan datos por introducir.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub OperacionAltaVenta()
        'Comprueba si el boton fue pulsado o por el contrario es la primera vez.
        If AltaVentaYaPulsado = False Then
            LimpiarTodo()
            BloqueoAltaVenta()
            MsgBox("Introduce el los datos..")
            AltaVentaYaPulsado = True
            'Ahora buscaremos el numero mayor en la columna codigo y le sumaremos uno para generar el codigo.
            Try
                comando.CommandText = "Select max(codigoVenta) from Ventas;"
                miLector = comando.ExecuteReader
                'Ahora se añade al TextBox..
                If miLector.HasRows = True Then
                    While miLector.Read
                        vCodigo.Text = Str(Val(miLector(0)) + 1)
                    End While
                    miLector.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf AltaVentaYaPulsado = True Then
            If esNoVacioVenta() = True Then
                Try
                    'Añade la consulta Insert seleccionada.
                    Dim miSentenciaSQL As String
                    If vPagado.Checked = True Then
                        miSentenciaSQL = "Insert Into Ventas (codigoVenta, fecha, precio, pagado, cliente,caballo) Values (" + vCodigo.Text + "," + vFecha.Value.Date + "," + vPrecio.Text + ", True, '" + cDni.Text + "' ,'" + cbCodigo.Text + "');"
                    Else
                        miSentenciaSQL = "Insert Into Ventas (codigoVenta, fecha, precio, pagado, cliente,caballo) Values (" + vCodigo.Text + "," + vFecha.Value.Date + "," + vPrecio.Text + ", False, '" + cDni.Text + "' ,'" + cbCodigo.Text + "');"
                    End If
                    comando.CommandText = miSentenciaSQL
                    comando.ExecuteNonQuery()
                    miSentenciaSQL = "Update Caballos Set vendido = True Where codigoCaballo = '" + cbCodigo.Text + "';"
                    comando.CommandText = miSentenciaSQL
                    comando.ExecuteNonQuery()
                    MsgBox("El registro se realizo correctamente.")
                    LimpiarTodo()
                    BloqueoAltaVenta()
                    bloqueoInicial()
                    AltaVentaYaPulsado = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Se encontraron errores.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub bloqueoInicial()
        Cliente.Enabled = False
        Ganadería.Enabled = False
        Venta.Enabled = False
        Caballo.Enabled = False
        AltaCaballo.Enabled = True
        AltaCliente.Enabled = True
        AltaGanadería.Enabled = True
        AltaVenta.Enabled = True
        ConsultaVenta.Enabled = True
        EliminaVenta.Enabled = True
        ModificaVenta.Enabled = True
        InformeVentas.Enabled = True
    End Sub
    Private Sub BloqueoAltaCliente()
        Cliente.Enabled = True
        Ganadería.Enabled = False
        Venta.Enabled = False
        Caballo.Enabled = False
        AltaCaballo.Enabled = False
        AltaGanadería.Enabled = False
        AltaVenta.Enabled = False
        ConsultaVenta.Enabled = False
        EliminaVenta.Enabled = False
        ModificaVenta.Enabled = False
        InformeVentas.Enabled = False
    End Sub

    Private Sub BloqueoAltaCaballo()
        Cliente.Enabled = False
        Ganadería.Enabled = False
        Venta.Enabled = False
        Caballo.Enabled = True
        AltaCliente.Enabled = False
        AltaGanadería.Enabled = False
        AltaVenta.Enabled = False
        ConsultaVenta.Enabled = False
        EliminaVenta.Enabled = False
        ModificaVenta.Enabled = False
        InformeVentas.Enabled = False
    End Sub

    Private Sub BloqueoAltaGanaderia()
        Cliente.Enabled = False
        Ganadería.Enabled = True
        Venta.Enabled = False
        Caballo.Enabled = False
        AltaCaballo.Enabled = False
        AltaCliente.Enabled = False
        AltaGanadería.Enabled = True
        AltaVenta.Enabled = False
        ConsultaVenta.Enabled = False
        EliminaVenta.Enabled = False
        ModificaVenta.Enabled = False
        InformeVentas.Enabled = False
    End Sub

    Private Sub BloqueoAltaVenta()
        If AltaVentaYaPulsado = False Then
            'Activamos los necesarios..
            Cliente.Enabled = True
            Venta.Enabled = True
            Ganadería.Enabled = True
            Caballo.Enabled = True
            vCodigo.Enabled = False
            cDni.Enabled = True
            cbCodigo.Enabled = True
            AltaCaballo.Enabled = False
            AltaCliente.Enabled = False
            AltaGanadería.Enabled = False
            AltaVenta.Enabled = True
            ConsultaVenta.Enabled = False
            EliminaVenta.Enabled = False
            ModificaVenta.Enabled = False
            InformeVentas.Enabled = False
            'Desactivamos los no necesarios..

            cNombre.Enabled = False
            cApellidos.Enabled = False
            cDireccion.Enabled = False
            cTelefono.Enabled = False
            cEmail.Enabled = False
            gCodigo.Enabled = False
            gNombre.Enabled = False
            gPropietario.Enabled = False
            gDireccion.Enabled = False
            gTelefono.Enabled = False
            gFax.Enabled = False
            gEmail.Enabled = False
            cbNombre.Enabled = False
            cbEdad.Enabled = False
            cbTipo.Enabled = False
            cbRaza.Enabled = False
            cbCapa.Enabled = False
            cbDisciplina.Enabled = False
            cbGanaderia.Enabled = False
        Else
            'Activamos todos
            cNombre.Enabled = True
            cApellidos.Enabled = True
            cDireccion.Enabled = True
            cTelefono.Enabled = True
            cEmail.Enabled = True
            gCodigo.Enabled = True
            gNombre.Enabled = True
            gPropietario.Enabled = True
            gDireccion.Enabled = True
            gTelefono.Enabled = True
            gFax.Enabled = True
            gEmail.Enabled = True
            cbNombre.Enabled = True
            cbEdad.Enabled = True
            cbTipo.Enabled = True
            cbRaza.Enabled = True
            cbCapa.Enabled = True
            cbDisciplina.Enabled = True
            cbGanaderia.Enabled = True
        End If
    End Sub

    Private Sub BloqueoAltaVentaModifica()
        If ModificaYaPulsado = False Then
            'Activamos los necesarios..
            Cliente.Enabled = True
            Venta.Enabled = True
            Ganadería.Enabled = True
            Caballo.Enabled = True
            vCodigo.Enabled = False
            cDni.Enabled = True
            cbCodigo.Enabled = True
            AltaCaballo.Enabled = False
            AltaCliente.Enabled = False
            AltaGanadería.Enabled = False
            AltaVenta.Enabled = False
            ConsultaVenta.Enabled = False
            EliminaVenta.Enabled = False
            ModificaVenta.Enabled = True
            InformeVentas.Enabled = False
            'Desactivamos los no necesarios..

            cNombre.Enabled = False
            cApellidos.Enabled = False
            cDireccion.Enabled = False
            cTelefono.Enabled = False
            cEmail.Enabled = False
            gCodigo.Enabled = False
            gNombre.Enabled = False
            gPropietario.Enabled = False
            gDireccion.Enabled = False
            gTelefono.Enabled = False
            gFax.Enabled = False
            gEmail.Enabled = False
            cbNombre.Enabled = False
            cbEdad.Enabled = False
            cbTipo.Enabled = False
            cbRaza.Enabled = False
            cbCapa.Enabled = False
            cbDisciplina.Enabled = False
            cbGanaderia.Enabled = False
        Else
            'Activamos todos
            cNombre.Enabled = True
            cApellidos.Enabled = True
            cDireccion.Enabled = True
            cTelefono.Enabled = True
            cEmail.Enabled = True
            gCodigo.Enabled = True
            gNombre.Enabled = True
            gPropietario.Enabled = True
            gDireccion.Enabled = True
            gTelefono.Enabled = True
            gFax.Enabled = True
            gEmail.Enabled = True
            cbNombre.Enabled = True
            cbEdad.Enabled = True
            cbTipo.Enabled = True
            cbRaza.Enabled = True
            cbCapa.Enabled = True
            cbDisciplina.Enabled = True
            cbGanaderia.Enabled = True
        End If
    End Sub

    Private Function esNoVacioCliente() As Boolean
        ErrorProvider1.Clear()
        'Comprueba que los datos de introducidos son validos.
        Dim aux As Boolean = True
        If cDni.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cDni, "Introduce un DNI.")
        End If
        If cNombre.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cNombre, "Introduce un Nombre.")
        End If
        If cApellidos.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cApellidos, "Introduce un Apellido.")
        End If
        If cDireccion.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cDireccion, "Introduce una dirección.")
        End If
        If cTelefono.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cTelefono, "Introduce una Teléfono.")
        End If
        If cEmail.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cEmail, "Introduce una Email.")
        End If
        If aux = True Then
            ErrorProvider1.Clear()
        End If
        Return aux
    End Function

    Private Function esNoVacioCaballo() As Boolean
        ErrorProvider1.Clear()
        'Comprueba que los datos de introducidos son validos.
        Dim aux As Boolean = True
        If cbCodigo.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbCodigo, "Introduce un Código.")
        End If
        If cbNombre.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbNombre, "Introduce un Nombre.")
        End If
        If cbEdad.Text = "" Or IsNumeric(cbEdad.Text) = False Then
            aux = False
            ErrorProvider1.SetError(cbEdad, "Introduce la Edad o es posible que no sea numerico..")
        End If
        If cbTipo.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbTipo, "Selecciona el tipo.")
        End If

        If cbRaza.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbRaza, "Selecciona la Raza.")
        End If
        If cbCapa.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbCapa, "Selecciona la Capa.")
        End If
        If cbDisciplina.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbDisciplina, "Selecciona la Disciplina.")
        End If
        If cbGanaderia.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbGanaderia, "Seleciona la Ganadería.")
        End If

        If cbVendido.Checked = False And cbNoVendido.Checked = False Then
            aux = False
            ErrorProvider1.SetError(cbNoVendido, "Seleciona uno de los dos.")
        End If
        If aux = True Then
            ErrorProvider1.Clear()
        End If
        Return aux
    End Function

    Private Function esNoVacioGanaderia() As Boolean
        ErrorProvider1.Clear()
        'Comprueba que los datos de introducidos son validos.
        Dim aux As Boolean = True
        If gCodigo.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gCodigo, "Introduce un Código.")
        End If
        If gNombre.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gNombre, "Introduce un Nombre.")
        End If
        If gPropietario.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gPropietario, "Introduce un Propietario.")
        End If
        If gDireccion.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gDireccion, "Introduce una Dirección.")
        End If
        If gTelefono.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gTelefono, "Introduce un Teléfono.")
        End If
        If gFax.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gFax, "Introduce un Fax.")
        End If
        If gEmail.Text = "" Then
            aux = False
            ErrorProvider1.SetError(gEmail, "Introduce un Email.")
        End If
        If aux = True Then
            ErrorProvider1.Clear()
        End If
        Return aux
    End Function

    Private Function esNoVacioVenta() As Boolean
        ErrorProvider1.Clear()
        'Comprueba que los datos de introducidos son validos.
        Dim aux As Boolean = True
        If cDni.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cDni, "Selecciona un Cliente.")
        End If
        If cbCodigo.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbCodigo, "Selecciona un Caballo.")
        End If
        If cbVendido.Checked = True Then
            aux = False
            ErrorProvider1.SetError(cbVendido, "No se puede vender un caballo ya vendido, selecciona otro disponible.")
        End If
        If vPrecio.Text = "" Then
            aux = False
            ErrorProvider1.SetError(vPrecio, "Introduce un Precio.")
        End If
        If vPagado.Checked = False And vNoPagado.Checked = False Then
            aux = False
            ErrorProvider1.SetError(vNoPagado, "Selecciona una opcción.")
        End If
        If aux = True Then
            ErrorProvider1.Clear()
        End If
        Return aux
    End Function

    Private Function esNoVacioModifico() As Boolean
        ErrorProvider1.Clear()
        'Comprueba que los datos de introducidos son validos.
        Dim aux As Boolean = True
        If cDni.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cDni, "Selecciona un Cliente.")
        End If
        If cbCodigo.Text = "" Then
            aux = False
            ErrorProvider1.SetError(cbCodigo, "Selecciona un Caballo.")
        End If
        If vPrecio.Text = "" Then
            aux = False
            ErrorProvider1.SetError(vPrecio, "Introduce un Precio.")
        End If
        If vPagado.Checked = False And vNoPagado.Checked = False Then
            aux = False
            ErrorProvider1.SetError(vNoPagado, "Selecciona una opcción.")
        End If
        If aux = True Then
            ErrorProvider1.Clear()
        End If
        Return aux
    End Function

    Private Sub AltaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaCliente.Click
        OperacionAltaCliente()
    End Sub

    Private Sub AltaCaballo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaCaballo.Click
        OperacionAltaCaballo()
    End Sub

    Private Sub cbGanaderia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGanaderia.SelectedIndexChanged
        Muestra_Ganaderia_Segun_Codigo()
    End Sub

    Private Sub AltaGanadería_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaGanadería.Click
        OperacionAltaGanaderia()
    End Sub

    Private Sub AltaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaVenta.Click
        OperacionAltaVenta()
    End Sub

    Private Sub ConsultaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaVenta.Click
        OperacionConsulta()
    End Sub

    Private Sub OperacionConsulta()
        'Pedimos los datos para realizar la consulta.
        Dim encontrado As Boolean = False
        LimpiarTodo()
        Dim codigo As String
        codigo = InputBox("Introduce codigo de la venta.")
        If codigo = "" Then
            MsgBox("La operación fue cancelada o no se introducieron datos.")
            Exit Sub
        End If
        Try
            comando.Connection = miConexion
            comando.CommandText = "Select * from Ventas where codigoVenta = " + codigo + ";"
            miLector.Close() 'Al colocar aqui close se soluciona el problema que con el adaptador abierto, en el examen.
            miLector = comando.ExecuteReader
            'Ahora se añade a los TextBox
            If miLector.HasRows = True Then
                While miLector.Read
                    If Str(miLector(0)) = "" Then
                        Exit While
                    End If
                    vCodigo.Text = miLector(0)
                    vFecha.Text = miLector(1)
                    vPrecio.Text = miLector(2)
                    If miLector(3) = "True" Then
                        vPagado.Checked = True
                    Else
                        vNoPagado.Checked = True
                    End If
                    cDni.Text = miLector(4)
                    cbCodigo.Text = miLector(5)
                    encontrado = True
                End While
                miLector.Close()
                MsgBox("Se encontraron los datos.", MsgBoxStyle.Information)
            End If
            'Comprueba si no fue encontrado.
            If encontrado = False Then
                MsgBox("No se encontraron los datos.", MsgBoxStyle.Exclamation)
            Else
                Muestra_Clientes_Segun_DNI()
                Muestra_Caballos_Segun_Codigo()
                Muestra_Ganaderia_Segun_Codigo()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub EliminaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaVenta.Click
        OperacionBaja()
    End Sub

    Private Sub OperacionBaja()
        OperacionConsulta()
        If vCodigo.Text = "" Then
            Exit Sub
        End If
        Try
            'Realizamos la operación de eliminación
            If MsgBox("¿Quiere eleminar los datos?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Borramos...
                comando.CommandText = "Delete from Ventas where codigoVenta = " + vCodigo.Text + ";"
                comando.ExecuteNonQuery()
                MsgBox("La eliminación se realizo correctamente.")
            Else
                MsgBox("La operacion fue cancelada", MsgBoxStyle.Exclamation)
                LimpiarTodo()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ModificaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaVenta.Click
        OperacionModifica()
    End Sub

    Private Sub OperacionModifica()
        If ModificaYaPulsado = False Then
            OperacionConsulta()
            'Comprobamos si esta vacio.. ya que se ser asi no habria encontrado nada.
            If vCodigo.Text = "" Then
                Exit Sub
            Else
                BloqueoAltaVentaModifica()
                ModificaYaPulsado = True
            End If
        ElseIf ModificaYaPulsado = True Then
            If esNoVacioModifico() = True Then
                Dim miSentenciaSQL As String
                Try
                    If vPagado.Checked = True Then
                        miSentenciaSQL = "Update Ventas set fecha = " + vFecha.Value.Date + ",precio = " + vPrecio.Text + " ,pagado = True, cliente = '" + cDni.Text + "', caballo = '" + cbCodigo.Text + "';"
                    Else
                        miSentenciaSQL = "Update Ventas set fecha = " + vFecha.Value.Date + ",precio = " + vPrecio.Text + " ,pagado = False, cliente = '" + cDni.Text + "', caballo = '" + cbCodigo.Text + "';"
                    End If
                    comando.CommandText = miSentenciaSQL
                    comando.ExecuteNonQuery()
                    'Ahora modificaremos el estado de vendido del caballo.
                    If cbVendido.Checked = True Then
                        miSentenciaSQL = "Update Caballos Set vendido = True Where codigoCaballo = '" + cbCodigo.Text + "';"
                        comando.CommandText = miSentenciaSQL
                        comando.ExecuteNonQuery()
                    Else
                        miSentenciaSQL = "Update Caballos Set vendido = False Where codigoCaballo = '" + cbCodigo.Text + "';"
                        comando.CommandText = miSentenciaSQL
                        comando.ExecuteNonQuery()
                    End If
                    MsgBox("La operación fue realizada")
                    LimpiarTodo()
                    BloqueoAltaVentaModifica()
                    bloqueoInicial()
                    ModificaYaPulsado = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Hay datos que necesitan una revisón..", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub InformeVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeVentas.Click
        'Creamos el informe y lo mostramos.
        Dim miInforme As New Informe_Ventas
        miInforme.ShowDialog()
    End Sub
End Class
