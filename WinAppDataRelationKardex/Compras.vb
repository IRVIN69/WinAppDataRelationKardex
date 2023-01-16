Imports System.Data.SqlClient
Public Class frmCompras
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oConeccion As New SqlConnection("server=.; Integrated security= true; Database=Kardex")
        Dim oDataAdaptar As New SqlDataAdapter("", oConeccion)
        Dim oDataSet As New DataSet()
        oDataAdaptar.SelectCommand.CommandText = "select C.IdCompra AS CompraID, CP.IdComprobante AS ComprobanteID, C.GuiaRemision AS Remision , R.Nombres+' '+R.Apellidos AS Responsable FROM COMPRA C JOIN RESPONSABLE R ON C.IdResponsable = R.IdResponsable JOIN COMPROBANTE_PAGO CP  ON C.IdComprobante  = CP.IdComprobante"
        oDataAdaptar.Fill(oDataSet, "COMPRA")
        oDataAdaptar.SelectCommand.CommandText = "select CD.IdCompra AS CompraID,CD.IdCompraDetalle as IDDetalleCompra, P.Nombre AS Producto, P.Stock AS Stock, P.PrecioBase AS PRECIO, CD.Cantidad AS CantidadComprada, SUM(P.PrecioBase*CD.Cantidad) AS TOTAL FROM [COMPRA_DETALLE] CD JOIN PRODUCTO P ON CD.CodProducto = P.CodProducto GROUP BY CD.IdCompra,CD.IdCompraDetalle, P.Nombre, P.Stock, P.PrecioBase, CD.Cantidad"
        oDataAdaptar.Fill(oDataSet, "COMPRA_DETALLE")
        Dim oDataRelation As New DataRelation("DETALLES_COMPRA", oDataSet.Tables(0).Columns(0), oDataSet.Tables(1).Columns(0))
        oDataSet.Relations.Add(oDataRelation)
        dgCompras.DataSource = oDataSet.Tables(0)
        dgCompras.Expand(0)
    End Sub
End Class