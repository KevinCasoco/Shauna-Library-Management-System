Public Class Missing_of_Books

    Private Sub Missing_of_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Issue_Dataset.Issue' table. You can move, or remove it, as needed.
        Me.IssueTableAdapter.Fill(Me.Issue_Dataset.Issue)
        'TODO: This line of code loads data into the 'Missing_Dataset.Missing' table. You can move, or remove it, as needed.
        Me.MissingTableAdapter.Fill(Me.Missing_Dataset.Missing)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MissingBindingSource.AddNew()
        txtMissingBooks.Select()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        On Error GoTo saveeror
        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MissingBindingSource.EndEdit()
            IssueBindingSource.EndEdit()
            MissingTableAdapter.Update(Missing_Dataset.Missing)
            IssueTableAdapter.Update(Issue_Dataset.Issue)
            Me.MissingTableAdapter.Fill(Me.Missing_Dataset.Missing)
            Me.IssueTableAdapter.Fill(Me.Issue_Dataset.Issue)

            MessageBox.Show("Books Successfully Missing!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

saveeror:
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MissingBindingSource.RemoveCurrent()

            MissingBindingSource.EndEdit()
            MissingTableAdapter.Update(Missing_Dataset.Missing)

            MessageBox.Show("Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Home_Page.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Home_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        List_of_Students.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        List_of_Students.Show()
        Me.Hide()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        List_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        List_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Issue_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Issue_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Return_of_Books.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Return_of_Books.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LogIn.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        MissingTableAdapter.Update(Missing_Dataset.Missing)
        IssueTableAdapter.Update(Issue_Dataset.Issue)
        Me.MissingTableAdapter.Fill(Me.Missing_Dataset.Missing)
        Me.IssueTableAdapter.Fill(Me.Issue_Dataset.Issue)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.MissingBindingSource.Filter = "[MISSING BOOK ID]  like '%" & txtMissingBooks.Text & "'"
    End Sub
End Class