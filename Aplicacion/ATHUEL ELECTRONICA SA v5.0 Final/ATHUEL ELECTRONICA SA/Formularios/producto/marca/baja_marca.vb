﻿Public Class baja_marca
    Dim _BD As New CONEXION_BD
    Dim _marca As New marca

    Private Sub cargar_grilla()
        dgv_vista.DataSource = _BD.leo_tabla("select * from marca")
    End Sub

    Private Sub borrar_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim _codigo As Integer
        _codigo = Me.dgv_vista.CurrentRow.Cells(0).Value
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & Me.dgv_vista.CurrentRow.Cells(1).Value & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me._marca.borrar(_codigo)
            MsgBox("el borrado se realizo con exito.")
                    Me.cargar_grilla()

        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class