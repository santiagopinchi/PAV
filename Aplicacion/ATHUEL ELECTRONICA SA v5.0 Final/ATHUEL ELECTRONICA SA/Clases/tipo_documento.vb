Public Class tipo_documento
    Dim _BD As New CONEXION_BD
    Public Property codigo As Integer
    Public Property nombre As String

    Public Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT tipo_documento (nombre)"
        sql &= "VALUES("
        sql &= ", '" & _nombre & "')"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE tipo_documento "
        sql &= "SET nombre ='" & Me._nombre & "'"
        sql &= "WHERE codTipodoc = " & Me._codigo

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod As String)
        Dim sql As String = ""
        sql &= "DELETE FROM tipo_documento"
        sql &= "WHERE codTipodoc = " & cod

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function validar() As String

        If Me._nombre = "" Then
            Return "El nombre esta vacio."
        End If
        Return "Correcta"
    End Function


    Public Sub buscar_tipos_documento(ByVal cod As String)
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM tipo_documento"
        sql &= " WHERE  codTipodoc = " & cod.Trim()
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero informacion")
            Me.blanquear()
        Else
            Me.transeferir(tabla)
        End If
    End Sub

    Private Sub transeferir(ByVal tabla As DataTable)
        _codigo = tabla.Rows(0)("codTipodoc")
        _nombre = tabla.Rows(0)("nombre")
    End Sub

    Private Sub blanquear()
        _codigo = 0
        _nombre = ""

    End Sub
End Class

