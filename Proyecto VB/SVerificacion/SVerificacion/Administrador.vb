Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Administrador_1
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensajé, sentencia As String
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim da As New SqlDataAdapter("select * from usuarios where ID_usuario = '" + TextBox4.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentencia = "insert into usuarios values( '" + TextBox4.Text + "','" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox5.Text + "')"
        mensajé = "Datos Ingresados Correctamente"
        EjecutarSql(sentencia, mensajé)
        Try
            Dim da As New SqlDataAdapter("select *from usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sentencia = "Delete usuarios where ID_usuario = '" + TextBox4.Text + "'"
        mensajé = "Datos eliminados correctamente"
        EjecutarSql(sentencia, mensajé)
        Try
            Dim da As New SqlDataAdapter("select *from usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sentencia = "update usuarios set nombre = '" + TextBox1.Text + "', apellido = '" + TextBox2.Text + "', correo= '" + TextBox3.Text + "', contraseña = '" + TextBox5.Text + "' where ID_usuario = '" + TextBox4.Text + "'"
        mensajé = "Datos actualizados correctamente"
        EjecutarSql(sentencia, mensajé)
        Try
            Dim da As New SqlDataAdapter("select *from usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    End Sub

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
End Class