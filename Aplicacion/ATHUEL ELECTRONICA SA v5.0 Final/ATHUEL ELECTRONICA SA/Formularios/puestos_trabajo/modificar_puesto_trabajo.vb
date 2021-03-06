﻿Public Class modificar_puesto_trabajo
    Dim _puesto As New puesto_trabajo
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD


    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM puestos_trabajo")
    End Sub

    Private Sub dgv_vista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellDoubleClick

        Me.txt_codigo.Text = dgv_vista.CurrentRow.Cells(0).Value
        Me.txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value
        Me.txt_descripcion.Text = dgv_vista.CurrentRow.Cells(2).Value.ToString


        Me.txt_codigo.Enabled = False
    End Sub

    Private Sub transferir_datos_puesto()
        Me._puesto.codPuesto = Integer.Parse(txt_codigo.Text)
        Me._puesto.descripcion = txt_descripcion.Text
        Me._puesto.nombre = txt_nombre.Text
    End Sub

    Private Sub blanquear()

        Me.txt_codigo.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_descripcion.Text = ""
        Me.txt_codigo.Focus()

    End Sub



    Private Sub modificar_puesto_trabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()

    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        transferir_datos_puesto()
        Dim mensaje As String = Me._puesto.validar()
        If mensaje <> "CORRECTO" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            Me._puesto.modificar(Integer.Parse(Me.txt_codigo.Text))
            MsgBox("el puesto de trabajo se modifico exitosamente")
            Me.blanquear()
            Me.cargar_grilla()
        End If


    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

End Class