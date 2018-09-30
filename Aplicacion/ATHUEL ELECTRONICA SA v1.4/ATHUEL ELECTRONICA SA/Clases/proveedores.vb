Public Class proveedores
    Dim _BD As New CONEXION_BD
    Public Property cuit As Long
    Public Property razon_social As String
    Public Property fecha_inicio As String
    Public Property tipo_proveedor As String

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT proveedor ("
        sql &= "cuit, razonSocial,fechaInicioAct, tipoProveedor)"
        sql &= " VALUES ("
        sql &= _cuit
        sql &= ",'" & _razon_social & "'"
        sql &= ", '" & _fecha_inicio & "'"
        sql &= ", '" & _tipo_proveedor & "')"
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub modificar(ByVal cuit As String)
        Dim sql As String = ""
        sql &= "UPDATE proveedor "
        sql &= "SET razonSocial = '" & Me._razon_social & "'"
        sql &= ", fechaInicioAct = '" & Me._fecha_inicio & "'"
        sql &= ", tipoProveedor = '" & Me._tipo_proveedor & "'"
        sql &= " WHERE cuit = " & Long.Parse(cuit)
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub borrar(ByVal cuit As Long)
        Dim sql As String = ""
        sql &= "DELETE FROM proveedor "
        sql &= " WHERE cuit = " & cuit
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Function validar() As String
        If Me._cuit = 0 Then
            Return "El CUIT esta vacío"
        End If
        If Me._razon_social = "" Then
            Return "La Razón Social esta vacía"
        End If
        If Me._fecha_inicio = "  /  /" Then
            Return "Falta la fecha de inicio de actividad"
        End If
        If Me._tipo_proveedor <> "E" Then
            If Me._tipo_proveedor <> "N" Then
                Return "El tipo de proveedor debe ser E o N"
            End If
        End If
        Return "CORRECTO"
    End Function
Public Sub buscar_proveedor(ByVal cuit As Long)
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = "SELECT * "
        sql &= ", convert(char(10),proveedor.fechaInicioAct, 103) as formateada "
        sql &= " FROM proveedor "
        sql &= " WHERE cuit = " & cuit
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero información")
            Me.blanquear()
        Else
            Me.traferir(tabla)
        End If
    End Sub
    Private Sub traferir(ByVal tabla As DataTable)
        _cuit = tabla.Rows(0)("cuit").text
        _razon_social = tabla.Rows(0)("razonSocial").text
        _fecha_inicio = tabla.Rows(0)("formateada").ToString
        _tipo_proveedor = tabla.Rows(0)("tipoProveedor").text
    End Sub
    Private Sub blanquear()
        _cuit = 0
        _razon_social = ""
        _fecha_inicio = ""
        _tipo_proveedor = ""
    End Sub
End Class