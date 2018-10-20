Public Class Contacto
    Public Property codTipodoc As Integer
    Public Property numeroDoc As Long
    Public Property nombre As String
    Public Property apellido As String
    Public Property telefono As Long
    Public Property mail As String
    Dim bd As New CONEXION_BD

    Public Sub isnertar()
        Dim sql As String = ""
        sql &= "INSERT contacto (codTipodoc, numeroDocumento, nombre, apellido, telefono, mail) VALUES"
        sql &= "(" & _codTipodoc & ", " & _numeroDoc & ", '" & _nombre & "', '" & _apellido & "', " & _telefono & ", '" & _mail & "')"
        bd.INS_MOD_BOR(sql)
    End Sub

    Public Sub moodificar()
        Dim sql As String = ""
        sql &= "UPDATE contacto SET nombre = '" & _nombre & "', apellido = '" & _apellido & "', telefono = " & _telefono & ", mail = '" & _mail & "' "
        sql &= "WHERE codTipodoc = " & _codTipodoc & " AND numeroDocumento= " & _numeroDoc
        bd.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar()
        Dim sql As String = ""
        sql &= "DELETE FROM contacto WHERE codTipodoc = " & _codTipodoc & " AND numeroDocumento= " & _numeroDoc
        bd.INS_MOD_BOR(sql)
    End Sub

    Public Function validar()
        If _codTipodoc = 0 Then
            Return "El tipo de documento no esta selecionado."
        End If
        If _numeroDoc = 0 Then
            Return "El numero de documento esta vacio."
        End If
        If _nombre = "" Then
            Return "El nombre esta vacio."
        End If
        If _apellido = "" Then
            Return "El apellido esta vacio."
        End If
        If _telefono = 0 Then
            Return "El telefono esta vacio."
        End If
        If _mail = "" Then
            Return "El mail esta vacio."
        End If
        Return "correcto"
    End Function
End Class
