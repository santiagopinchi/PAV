Public Class conexion_BD_transaccion
    Enum tipo_conexion
        simple
        transaccion
    End Enum
    Enum estado_proceso
        _ok
        _error
    End Enum
    Dim control_conexion As tipo_conexion = tipo_conexion.simple
    Dim control_estado As estado_proceso = estado_proceso._ok

    Dim conexion As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim transaccion As OleDb.OleDbTransaction
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-RMR539N;Integrated Security=SSPI;Initial Catalog=Athuel_Electronica_SA"
    Public Sub iniciar_transaccion()
        control_conexion = tipo_conexion.transaccion
        control_estado = estado_proceso._ok
    End Sub
    Public Sub fin_transaccion()
        If conexion.State = ConnectionState.Closed Then
            Exit Sub
        End If
        If control_conexion = tipo_conexion.transaccion Then
            If control_estado = estado_proceso._ok Then
                transaccion.Commit()
                MsgBox("se grabó correctamente")
            Else
                transaccion.Rollback()
                MsgBox("se produjo errores no se grabó")
            End If
            conexion.Close()
        End If
        control_conexion = tipo_conexion.simple
    End Sub
    Private Function conectar() As estado_proceso
        If control_conexion = tipo_conexion.transaccion Then
            If conexion.State = ConnectionState.Open Then
                Return estado_proceso._ok
            End If
        End If
        conexion.ConnectionString = cadena_conexion
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("No conecto, verifica cadena de conexion")
            control_estado = estado_proceso._error
            Return estado_proceso._error
        End Try

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        If control_conexion = tipo_conexion.transaccion Then
            transaccion = conexion.BeginTransaction
            cmd.Transaction = transaccion
        End If
        Return estado_proceso._ok
    End Function
    Private Sub desconetar()
        If control_conexion = tipo_conexion.simple Then
            conexion.Close()
        End If
    End Sub
    Public Function INS_MOD_BOR(ByVal comando As String) As estado_proceso
        If conectar() = estado_proceso._error Then
            Return estado_proceso._error
        End If
        cmd.CommandText = comando
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo erro en el comando:" _
                    + Chr(13) + comando _
                    + Chr(13) + ex.Message)
            control_estado = estado_proceso._error
            Return estado_proceso._error
        Finally
            desconetar()
        End Try
        Return estado_proceso._ok
    End Function
    Public Function leo_tabla(ByVal sql As String) As DataTable
        Dim tabla As New DataTable
        conectar()
        cmd.CommandText = sql
        Try
            tabla.Load(cmd.ExecuteReader())
        Catch ex As Exception
            MsgBox("error en el comando:" _
                    + Chr(13) + sql _
                    + Chr(13) + ex.Message)
            Return New DataTable
        End Try
        desconetar()
        Return tabla
    End Function
End Class
