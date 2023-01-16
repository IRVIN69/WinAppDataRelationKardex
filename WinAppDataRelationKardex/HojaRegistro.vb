Imports System.Data.SqlClient
Public Class frmVentas
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oconeccion As New SqlConnection("server=.; integrated security=true; database=Kardex")
        Dim oDataAdapter As New SqlDataAdapter("", oconeccion)
        Dim oDataSet As New DataSet()
        oDataAdapter.SelectCommand.CommandText = "select HD.IdRegistro as IdRegistro, HD.FechaApertura as [Fecha Apertura],	P.Descripcion as [Descripción Producto], P.UnidadMedida as [Unidad de Medida], P.PrecioBase as [Precio Base] from HOJA_REGISTRO HD inner join PRODUCTO P on HD.CodProducto=P.CodProducto"
        oDataAdapter.Fill(oDataSet, "HojaRegistro")
        oDataAdapter.SelectCommand.CommandText = "select K.IdRegistro as IdRegistro, R.Apellidos+' '+R.Nombres as Responsable, K.NroDoc as [N° Documento], K.TipoDoc as Documento, K.CodProducto as codProducto, PR.RazonSocial as Proveedor, K.PrecioDocumento as [Precio Documento], K.StockActual as [Stock Actual], K.StockAnterior as [Stock Anterior], K.TipoMov as [Tipo Movimiento], K.CantidadEntrada as [Cantidad Entrada], K.CantidadSalida as [Cantidad Salidad] from KARDEX	K inner join HOJA_REGISTRO HD on K.IdRegistro=HD.IdRegistro inner join PRODUCTO P on HD.CodProducto=P.CodProducto inner join PROVEEDOR PR on P.IdProveedor=PR.IdProveedor inner join COMPRA_DETALLE CD on P.CodProducto=CD.CodProducto inner join COMPRA CP on CD.IdCompra=CP.IdCompra inner join RESPONSABLE R on CP.IdResponsable=R.IdResponsable"
        oDataAdapter.Fill(oDataSet, "Kardex")
        Dim oDataRelation As New DataRelation("Detalle Kardex", oDataSet.Tables(0).Columns(0), oDataSet.Tables(1).Columns(0))
        oDataSet.Relations.Add(oDataRelation)
        DataGrid1.DataSource = oDataSet.Tables(0)
        DataGrid1.Expand(0)
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmPrincipal.Show()
    End Sub
End Class