Imports System.Text
Imports System.Security.Cryptography
Public Class usuario
    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Dim _BD As New CONEXION_BD
    Public Property legajo As Integer
    Public Property nombreUsuario As String
    Public Property password As String
    Public Property pregunta_seguridad As String
    Public Property respuesta As String

    Public Function validarLogin() As estado_validar

        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM    usuario   WHERE "
        sql &= "nombreUsuario = '" & _nombreUsuario.Trim() & "'" 'caracteristica de texto limpio, sacar todos los espacios que estan a la izquierda Y derecha
        sql &= "AND contraseña = '" & Encriptar(_password) & "'"
        tabla = Me._BD.leo_tabla(sql)
        If tabla.Rows.Count() = 0 Then
            Return estado_validar.no_encontrado
        End If
        Return estado_validar.encontrado

    End Function

    Public Sub insertar()
        Dim sql As String = "INSERT usuario (legajo, nombreUsuario, contraseña, pregunta_control, respuesta) VALUES ("
        sql &= _legajo & ", '" & _nombreUsuario & "', '" & Encriptar(_password) & "', '" & _pregunta_seguridad & "', '" & _respuesta & "')"
        _BD.INS_MOD_BOR(sql)
    End Sub


    Public Sub modificar()
        Dim sql As String = "UPDATE usuario SET contraseña = '" & Encriptar(_password) & "' WHERE legajo = " & _legajo
        _BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub buscar()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM usuario WHERE legajo =" & _legajo)
        _nombreUsuario = tabla.Rows(0)("nombreUsuario")
        _password = Desencriptar(tabla.Rows(0)("contraseña"))
    End Sub
    Private Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Private Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Sub bloquear()
        Dim sql As String = "UPDATE usuario SET contraseña = '000000' WHERE legajo = " & _legajo
        _BD.INS_MOD_BOR(sql)
    End Sub

    Public Function estaBloqueado() As Boolean
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM usuario WHERE nombreUsuario='" & _nombreUsuario & "'")
        If tabla.Rows.Count = 0 Then
            Return False
        End If
        If tabla(0)("contraseña") = "000000" Then
            Return True
        End If
        Return False
    End Function
    Public Function estaBloqueadoRestaurar() As Boolean
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM usuario WHERE legajo=" & _legajo)
        If tabla.Rows.Count = 0 Then
            Return False
        End If
        If tabla(0)("contraseña") = "000000" Then
            Return True
        End If
        Return False
    End Function
End Class
