Public Class producto
    Dim _BD As New CONEXION_BD
    Public Property modelo As String
    Public Property codMarca As Integer
    Public Property codProducto As Integer
    Public Property descripcion As String 'As Date
    Public Property fechaFabricacion As String
    Public Property cantidad As Integer
    Public Property codigoTipoprod As String

    Public Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT producto"
        sql &= "(codTipoProd, codProd, codmarca, descripcion, modelo, fechaFabricacion, cantidad)"
        sql &= "VALUES("
        sql &= "'" & _codigoTipoprod & "'"
        sql &= "," & _codProducto
        sql &= "," & _codMarca
        sql &= ", '" & _descripcion & "'"
        sql &= ",'" & _modelo & "'"
        sql &= ", '" & _fechaFabricacion & "'"
        sql &= "," & _cantidad ")"
        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE producto "
        sql &= "SET cantidad =" & Me._cantidad
        sql &= ", codmarca ='" & Me._codMarca
        sql &= ", descripcion =" & Me._descripcion
        sql &= ", fechaFabricacion ='" & Me._fechaFabricacion & "'"
        sql &= "WHERE codTipoProd = '" & Me.codigoTipoprod & "'"
        sql &= "AND codProd = " & Me._codProducto


        Me._BD.INS_MOD_BOR(sql)
    End Sub


    Public Sub borrar(ByVal codProd As Integer, ByVal codTipoProd As String)
        Dim sql As String = ""
        sql &= "DELETE FROM producto"
        sql &= "WHERE codTipoProd = '" & codTipoProd & "'"
        sql &= "AND codProd = " & codProd

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function validar() As String
        If Me._modelo = "" Then
            Return "El Modelo esta vacio."
        End If
        If Me._fechaFabricacion = "  /  /   " Then
            Return "Falta la fecha fabricacion"
        End If
        Return "Correcta"
    End Function

    Public Sub buscar_producto(ByVal codTipoProd As String, ByVal codigoProd As Long)
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM producto "
        sql &= " WHERE  codTipoProd = '" & codTipoProd.Trim() "'"
        sql &= " AND codProd = " & codigoProd
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero informacion")
            Me.blanquear()
        Else
            Me.transeferir(tabla)

        End If
    End Sub

    Private Sub transeferir(ByVal tabla As DataTable)
        _codigoTipoprod = tabla.Rows(0)("codigoTipoprod")
        _codProducto = tabla.Rows(0)("codProducto")
        _codMarca = tabla.Rows(0)("codMarca")
        If String.IsNullOrEmpty(tabla.Rows(0)("descripcion")) Then
            _descripcion = ""
        Else
            _descripcion = tabla.Rows(0)("descripcion")
        End If
        _modelo = tabla.Rows(0)("modelo ")
        _fechaFabricacion = tabla.Rows(0)("fechaFabricacion").ToString
        _cantidad = tabla.Rows(0)("cantidad")
    End Sub


    Private Sub blanquear()
        _modelo = ""
        _codMarca = 0
        _codProducto = 0
        _descripcion = ""
        _fechaFabricacion = ""
        _cantidad = 0
        _codigoTipoprod = ""

    End Sub
End Class


