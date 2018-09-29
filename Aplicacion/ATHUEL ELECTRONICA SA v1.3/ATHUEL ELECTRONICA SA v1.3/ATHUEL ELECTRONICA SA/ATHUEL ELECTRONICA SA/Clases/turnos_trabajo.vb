Public Class turno_trabajo
    Dim _BD As New CONEXION_BD
    Public Property codigo As Integer
    Public Property horaInicio As String
    Public Property horaFin As String


    Public Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT turnos_trabajo (codTurno, horaInicio, horaFin)"
        sql &= "VALUES( " & _codigo
        sql &= ", '" & _horaInicio & "'"
        sql &= ", '" & _horaFin & "')"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE turnos_trabajo "
        sql &= "SET horaInicio = '" & _horaInicio & "'"
        sql &= ", horaInicio = '" & _horaFin & "')"
        sql &= "WHERE codTurno = " & Me._codigo

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod As String)
        Dim sql As String = ""
        sql &= "DELETE FROM turnos_trabajo"
        sql &= "WHERE codTurno = " & cod

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function validar() As String
        If Me._codigo = 0 Then
            Return "Falta el codigo del turno."
        End If
        If Me._horaInicio = "::" Then
            Return "Falta la hora inicio."
        End If
        If Me._horaFin = "::" Then
            Return "Falta la hora fin."
        End If
        Return "Correcta"
    End Function


    Public Sub buscar_turnos_trabajo(ByVal cod As String)
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM turnos_trabajo"
        sql &= " WHERE  codTurno = " & cod.Trim()
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero informacion")
            Me.blanquear()
        Else
            Me.transeferir(tabla)
        End If
    End Sub

    Private Sub transeferir(ByVal tabla As DataTable)
        _codigo = tabla.Rows(0)("codTurno")
        _horaInicio = tabla.Rows(0)("horaInicio")
        _horaFin = tabla.Rows(0)("horaFin")
    End Sub

    Private Sub blanquear()
        _codigo = 0
        _horaInicio = ""
        _horaFin = ""


    End Sub
End Class

