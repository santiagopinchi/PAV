Public Class marca
    Dim _BD As New CONEXION_BD
    Public Property codigo As Integer
    Public Property nombre As String

    Public Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT marca (nombre)"
        sql &= "VALUES("
        sql &= ", '" & _nombre & "')"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE marca "
        sql &= "SET nombre ='" & Me._nombre & "'"
        sql &= "WHERE codmarca = " & Me._codigo

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod As String)
        Dim sql As String = ""
        sql &= "DELETE FROM marca"
        sql &= "WHERE codmarca = " & cod

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function validar() As String
        If Me._nombre = "" Then
            Return "El nombre esta vacio."
        End If
        Return "Correcta"
    End Function

    '    Public Function buscar_si_existe(ByVal cod As integer)
    '        	Dim sql As String = ""
    '		Dim tabla As New DataTable
    '        	sql = "SELECT * FROM marca"
    '        	sql &= " WHERE  codmarca = " & cod
    '		tabla Me._BD.leo_tabla(sql)
    '        
    '	If dataTabla.Rows.Count=0 Then
    '            return "Correcto"
    '        Else
    '            return "Error"
    '        End If
    '    End Function

    Public Sub buscar_marca(ByVal cod As String)
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM marca"
        sql &= " WHERE  codmarca = " & cod.Trim()
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero informacion")
            Me.blanquear()
        Else
            Me.transeferir(tabla)
        End If
    End Sub

    Private Sub transeferir(ByVal tabla As DataTable)
        _codigo = tabla.Rows(0)("codmarca")
        _nombre = tabla.Rows(0)("nombre")
    End Sub

    Private Sub blanquear()
        _codigo = 0
        _nombre = ""
    End Sub
End Class


