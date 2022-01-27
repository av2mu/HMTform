Imports System.IO
Imports System.Text

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim text As New StringBuilder

        text.AppendLine(TextBox1.Text + "  " + TextBox2.Text)
        text.AppendLine(TextBox3.Text + "  " + TextBox4.Text)
        Dim filepath As String = "C:\Users\anish\Desktop\text.dat"
        File.WriteAllText(filepath, "")
        File.AppendAllText(filepath, text.ToString())
    End Sub

    Private Sub Number1_Click(sender As Object, e As EventArgs) Handles Number1.Click
        TextBox1.Clear()
    End Sub

    Private Sub Number2_Click(sender As Object, e As EventArgs) Handles Number2.Click
        TextBox2.Clear()
    End Sub

    Private Sub Number3_Click(sender As Object, e As EventArgs) Handles Number3.Click
        TextBox3.Clear()
    End Sub

    Private Sub Number4_Click(sender As Object, e As EventArgs) Handles Number4.Click
        TextBox4.Clear()
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub
End Class
