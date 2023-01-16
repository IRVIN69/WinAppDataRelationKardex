Public Class frmPrincipal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHR.Click
        frmVentas.Show()
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        frmCompras.Show()
    End Sub
End Class
