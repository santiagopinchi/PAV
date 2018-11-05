Public Class alta_puesto_trabajo
    Dim _BD As New CONEXION_BD
    Dim _puesto As New puesto_trabajo
    Dim _TE As New tratamientos_especiales

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        transeferir_datos()
        Dim mensaje As String = Me._puesto.validar()
        If mensaje <> "CORRECTO" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If _BD.leo_tabla("SELECT * FROM puestos_trabajo WHERE codPuesto= " & Integer.Parse(txt_codigo.Text)).Rows.Count = 0 Then
            _puesto.insertar()
            MsgBox("El puesto de trabajo se cargo exitosamente.")
            Me.blanquear()
        Else
            MsgBox("El código del puesto de trabajo ya existe.")
            Exit Sub
        End If
    End Sub
    Private Sub transeferir_datos()
        If txt_codigo.Text = "" Then
            Me._puesto.codPuesto = 0
        Else
            Me._puesto.codPuesto = Integer.Parse(txt_codigo.Text)
        End If
        Me._puesto.descripcion = txt_descripcion.Text
        Me._puesto.nombre = txt_nombre.Text
    End Sub

    Private Sub blanquear()
        Me.txt_codigo.Text = 0
        Me.txt_descripcion.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_codigo.Focus()
    End Sub

    Private Sub alta_puesto_trabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class