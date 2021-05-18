Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hidden_button.Visible = True



    End Sub

    Private Sub Hidden_button_Click(sender As Object, e As EventArgs) Handles Hidden_button.Click
        Hidden_button.Visible = False
        Entry.Visible = True
        Label2.Visible = True
        Enter1.Visible = True






    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click


    End Sub

    Private Sub Entry_TextChanged(sender As Object, e As EventArgs) Handles Entry.TextChanged



    End Sub

    Private Sub Enter1_Click(sender As Object, e As EventArgs) Handles Enter1.Click
        Dim range As Integer
        range = Entry.Text

        Select Case range

            Case 90 To 100
                MsgBox("Great Job")
                Hidden_button.Visible = False
                Entry.Visible = False
                Label2.Visible = False
                Enter1.Visible = False

            Case 80 To 89
                MsgBox("Great Work")
                Hidden_button.Visible = False
                Entry.Visible = False
                Label2.Visible = False
                Enter1.Visible = False

            Case 70 To 79
                MsgBox("OK")
                Hidden_button.Visible = False
                Entry.Visible = False
                Label2.Visible = False
                Enter1.Visible = False

            Case 0 To 69
                MsgBox("Better Luck Next Time")
                Hidden_button.Visible = False
                Entry.Visible = False
                Label2.Visible = False
                Enter1.Visible = False


        End Select

    End Sub
End Class
