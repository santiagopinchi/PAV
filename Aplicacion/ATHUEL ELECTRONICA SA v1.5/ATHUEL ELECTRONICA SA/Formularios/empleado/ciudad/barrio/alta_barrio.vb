Public Class alta_barrio
    Dim _BD As New CONEXION_BD
    Dim _barrio As New barrio
    Dim _TE As New tratamientos_especiales

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub blanquear()
        Me.txt_nombre.Text = ""
        Me.cmb_ciudad.SelectedIndex = -1

    End Sub
    Private Sub alta_barrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _BD.llenar_combo(cmb_ciudad, _BD.leo_tabla("SELECT * FROM ciudad"), "nombre", "codCiudad")
        'cmb_ciudad.DataSource = _BD.leo_tabla("SELECT * FROM ciudad")
        'cmb_ciudad.DisplayMember = "nombre"
        'cmb_ciudad.ValueMember = "codCiudad"
        blanquear()
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_alta_barrio.DataSource = _BD.leo_tabla("SELECT * FROM barrio")
    End Sub

    Private Sub transferir_datos_barrio()
        Me._barrio.nombre = txt_nombre.Text
        Me._barrio.codCiudad = cmb_ciudad.SelectedIndex

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir_datos_barrio()
        Dim mensaje As String = Me._barrio.validar()
        If mensaje <> "Correcta" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            Me._barrio.insertar()
            MsgBox("El barrio se grabó con éxito")
            Me.blanquear()
            cargar_grilla()
        End If
    End Sub
End Class