Imports System.Data.OleDb
Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles passTxt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim success As Boolean
        success = True
        If passTxt.Text = "" And uernameTxt.Text = "" Then
            userLblerr.Visible = True
            passLblerr.Visible = True
        ElseIf passTxt.Text = "" Then
            passLblerr.Visible = True
            userLblerr.Visible = False
        ElseIf uernameTxt.Text = "" Then
            userLblerr.Visible = True
            passLblerr.Visible = False
        Else
            userLblerr.Visible = False
            passLblerr.Visible = False
            success = User.correctpass(uernameTxt.Text, passTxt.Text)
            If success Then
                MsgBox("Next Form")
            Else
                MsgBox("Incorrect Credentials")
            End If
        End If

    End Sub
End Class
