Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text
Imports DevComponents
Imports DevComponents.DotNetBar
Imports DevComponents.Editors
Imports DevComponents.DotNetBar.Metro
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges
Imports DevExpress.XtraGrid
Imports Encryption
Imports Encryption.Crypt

Public Class frmSample
    Inherits MetroForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 100


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DigitalGauge1.Text = Now.ToString

    End Sub

    Private Sub MetroTabItem1_Click(sender As Object, e As EventArgs) Handles MetroTabItem1.Click

    End Sub

    Private Sub MetroTabItem2_Click(sender As Object, e As EventArgs) Handles MetroTabItem2.Click

    End Sub
End Class
