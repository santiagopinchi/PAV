﻿Public Class CONEXION_BD

    Dim conexion As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim _cadena_conexion As String = "Provider=SQLNCLI11;Data Source=LENOVO-GONZALO\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Athuel_Electronica_SA"
    'Public Property cadena_conexion As String
    Private Sub conectar()
        conexion.ConnectionString = _cadena_conexion
        conexion.Open() 'cambiar cadena de conexion
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
    End Sub
    Private Sub cerrar()
        conexion.Close()
    End Sub
    Public Sub INS_MOD_BOR(ByVal comando As String)
        Me.conectar()
        cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        cerrar()
    End Sub
    Public Function leo_tabla(ByVal sql As String) As DataTable
        Me.conectar()
        cmd.CommandText = sql
        Dim tabla As New DataTable
        tabla.Load(cmd.ExecuteReader())
        cerrar()
        Return tabla
    End Function

    Public Sub llenar_combo(ByVal cmb As ComboBox, ByVal source As Object, ByVal display As String, ByRef value As String)
        cmb.DataSource = source
        cmb.DisplayMember = display
        cmb.ValueMember = value
        cmb.SelectedIndex = -1
    End Sub
End Class
