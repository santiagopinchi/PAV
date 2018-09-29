Public Class usuario

    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Dim _BD As New CONEXION_BD
    Public Property Legajo As Integer
    Public Property nombreUsuario As String
    Public Property password As String

    Public Function validarLogin() As estado_validar

        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM    usuario   WHERE "
        sql &= "nombreUsuario = '" & _nombreUsuario.Trim() & "'" 'caracteristica de texto limpio, sacar todos los espacios que estan a la izquierda Y derecha
        sql &= "AND contraseña = '" & _password & "'"
        tabla = Me._BD.leo_tabla(sql)
        If tabla.Rows.Count() = 0 Then
            Return estado_validar.no_encontrado
        End If
        Return estado_validar.encontrado

    End Function

End Class
