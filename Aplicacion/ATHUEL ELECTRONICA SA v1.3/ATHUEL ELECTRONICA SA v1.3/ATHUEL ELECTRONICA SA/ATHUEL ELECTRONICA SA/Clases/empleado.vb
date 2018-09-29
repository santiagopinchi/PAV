Public Class empleado
    Dim _BD As New CONEXION_BD
    Public Property legajo As Integer
    Public Property tipo_documento As Integer
    Public Property nro_documento As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property calle As String
    Public Property fecha_ingreso As Date
    Public Property fecha_nac As Date
    Public Property id_barrio As Integer

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO empleado ("
        sql &= "legajo, codTipodoc, numeroDocumento, nombre, apellido"
        sql &= ", calle, fechaIngreso, fechaNacimiento, codBarrio)"
        sql &= "VALUES ("
        sql &= _legajo
        sql &= ", " & _tipo_documento
        sql &= ", " & _nro_documento
        sql &= ",'" & _nombre & "'"
        sql &= ",'" & _apellido & "'"
        sql &= ",'" & _calle & "'"
        sql &= "," & _fecha_ingreso
        sql &= "," & _fecha_nac
        sql &= "," & _id_barrio & ")"
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE empleado "
        sql &= "SET legajo = " & Me._legajo
        sql &= ", codTipoDoc = " & Me._tipo_documento
        sql &= ", numeroDocumento = " & Me._nro_documento
        sql &= ", nombre = '" & Me._nombre & "'"
        sql &= ", apellido = '" & Me._apellido & "'"
        sql &= ", calle = '" & Me._calle & "'"
        sql &= ", fechaIngreso = " & Me._fecha_ingreso
        sql &= ", fechaNacimiento = " & Me._fecha_nac
        sql &= ", codBarrio = " & Me._id_barrio & ")"
        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Sub borrar(ByVal legajo As Integer)
        Dim sql As String = ""
        sql &= "DELETE FROM empleado "
        sql &= "WHERE legajo = " & legajo

        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Function validar() As String
        If Me._legajo = 0 Then
            Return "El legajo está vacío"
        End If
        If Me._tipo_documento = 0 Then
            Return "El tipo de documento está vacío"
        End If
        If Me._nro_documento = "" Then
            Return "El número de documento está vacío"
        End If
        If Me._nombre = "" Then
            Return "El nombre está vacío"
        End If
        If Me._apellido = "" Then
            Return "El apellido está vacío"
        End If
        If Me._calle = "" Then
            Return "La calle está vacía"
        End If
        If Me._fecha_ingreso = " / /" Then
            Return "La fecha de ingreso está vacía"
        End If
        If Me._fecha_nac = " / /" Then
            Return "La fecha de nacimiento está vacía"
        End If
        If Me._id_barrio = 0 Then
            Return "El código del barrio está vacío"
        End If
        Return "Validación correcta"
    End Function
    Public Sub buscar_empleado(ByVal legajo As Integer)
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT *, convert(char(10),empleado.fechaNacimiento,103), "
        sql &= "convert(char(10),empleado.fechaIngreso,103)"
        sql &= " FROM empleado "
        sql &= " WHERE legajo = " & legajo
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se ha encontrado al empleado")
            Me.blanquear()
        Else
            Me.transferir(tabla)
        End If
    End Sub
    Private Sub transferir(ByVal tabla As DataTable)
        _legajo = tabla.Rows(0)("legajo")
        _tipo_documento = tabla.Rows(0)("tipoDocumento")
        _nro_documento = tabla.Rows(0)("numeroDocumento")
        _nombre = tabla.Rows(0)("nombre")
        _apellido = tabla.Rows(0)("apellido")
        _calle = tabla.Rows(0)("calle")
        _fecha_ingreso = tabla.Rows(0)("Legajo")
        _fecha_nac = tabla.Rows(0)("Legajo")
        _id_barrio = tabla.Rows(0)("Legajo")
    End Sub

    Private Sub blanquear()
        _legajo = 0
        _tipo_documento = ""
        _nro_documento = 0
        _nombre = ""
        _apellido = ""
        _calle = ""
        _fecha_ingreso = ""
        _fecha_nac = ""
        _id_barrio = 0
    End Sub
End Class
