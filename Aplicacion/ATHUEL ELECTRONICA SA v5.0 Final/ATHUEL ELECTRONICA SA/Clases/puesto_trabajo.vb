Public Class puesto_trabajo
    Public Property codPuesto As Integer
    Public Property nombre As String
    Public Property descripcion As String
    Dim _BD As New CONEXION_BD

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT puestos_trabajo ("
        sql &= "codPuesto, nombre, descripcion)"
        sql &= " VALUES (" & _codPuesto
        sql &= ",'" & _nombre & "'"
        sql &= ", '" & _descripcion & "')"
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub modificar(ByVal codigoPuesto As Integer)
        Dim sql As String = ""
        sql &= "UPDATE puestos_trabajo "
        sql &= "SET nombre = '" & Me._nombre & "'"
        sql &= ", descripcion = '" & Me._descripcion & "'"
        sql &= " WHERE codPuesto = " & codigoPuesto
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub borrar(ByVal codPuesto As Integer)
        Dim sql As String = ""
        sql &= "DELETE FROM puestos_trabajo "
        sql &= " WHERE codPuesto = " & codPuesto
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Function validar() As String
        If Me._codPuesto = 0 Then
            Return "El codigo del puesto esta vacío"
        End If
        If Me._nombre = "" Then
            Return "La nombre del puesto esta vacía"
        End If
        Return "CORRECTO"
    End Function

    Public Sub buscar_puesto(ByVal codPuesto As Integer)
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = "SELECT * "
        sql &= " FROM puestos_trabajo "
        sql &= " WHERE codPuesto = " & codPuesto
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero información")
            Me.blanquear()
        Else
            Me.traferir(tabla)
        End If
    End Sub
    Private Sub traferir(ByVal tabla As DataTable)
        _codPuesto = tabla.Rows(0)("codPuesto")
        _nombre = tabla.Rows(0)("nombre")
        _descripcion = tabla.Rows(0)("descripcion").ToString
    End Sub
    Private Sub blanquear()
        _codPuesto = 0
        _nombre = ""
        _descripcion = ""
    End Sub
End Class

