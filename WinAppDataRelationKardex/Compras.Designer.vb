﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgCompras = New System.Windows.Forms.DataGrid()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCompras
        '
        Me.dgCompras.DataMember = ""
        Me.dgCompras.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCompras.Location = New System.Drawing.Point(53, 96)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.Size = New System.Drawing.Size(469, 349)
        Me.dgCompras.TabIndex = 0
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 501)
        Me.Controls.Add(Me.dgCompras)
        Me.Name = "frmCompras"
        Me.Text = "Compras"
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgCompras As DataGrid
End Class
