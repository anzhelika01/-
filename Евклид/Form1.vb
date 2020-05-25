Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Algoritm()
        Do While a <> 0 And b <> 0
            If a > b Then
                a = a Mod b
            Else
                b = b Mod a
            End If
        Loop
        c = a + b
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                a = Integer.Parse(TextBox1.Text)
            Catch ex As Exception
                MsgBox("Enter an integer")
                Throw ex
            End Try
            Try
                b = Integer.Parse(TextBox2.Text)
            Catch ex As Exception
                MsgBox("Enter an integer")
                Throw ex
            End Try
        Catch ex As Exception
            Return
        End Try
        Algoritm()
        TextBox3.Text = c.ToString
    End Sub
End Class