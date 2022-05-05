Public Class LogIn

    Dim Attempt As Integer = 0
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs)
       
    End Sub

   
    



    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLogIn_Click_1(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "1234" Then
            Home_Page.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Hide()
        ElseIf txtUsername.Text = "andrei" And txtPassword.Text = "1234" Then
            List_of_Books.Show()
            Me.Hide()
        ElseIf txtUsername.Text = "kevin" And txtPassword.Text = "1234" Then
            Students.Show()
            Me.Hide()

        ElseIf txtUsername.Text = "casoco" And txtPassword.Text = "1234" Then
            List_of_Students.Show()
            Me.Hide()

        ElseIf txtUsername.Text = "shauna" And txtPassword.Text = "1234" Then
            Issue_of_Books.Show()
            Me.Hide()
        ElseIf txtUsername.Text = "karrie" And txtPassword.Text = "1234" Then
            Return_of_Books.Show()
            Me.Hide()

        ElseIf txtUsername.Text = "estes" And txtPassword.Text = "1234" Then
            Missing_of_Books.Show()
            Me.Hide()


        ElseIf Attempt = 3 Then
            MessageBox.Show("Maximum Log in Attempt!!")
            Close()

        Else
            MessageBox.Show("Your username ans password is incorrect!!")
            Attempt = Attempt + 1
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Select()

        End If
    End Sub
End Class