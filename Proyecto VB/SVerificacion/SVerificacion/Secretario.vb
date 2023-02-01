Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Secretario_0
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensajé, sentencia As String
    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter("select * from usuarios where ID_usuario = '" + TextBox1.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim da As New SqlDataAdapter("select *from usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Secretario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class