Public Class Issue_of_Books


    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Issue_Dataset.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter1.Fill(Me.Issue_Dataset.Books)
        'TODO: This line of code loads data into the 'Issue_Dataset.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter1.Fill(Me.Issue_Dataset.Students)
        'TODO: This line of code loads data into the 'Books_Dataset.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Books_Dataset.Books)

    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Students_Dataset.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.Students_Dataset.Students)

    End Sub

    Private Sub Issue_of_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Books_Dataset.Books' table. You can move, or remove it, as needed.
        Me.IssueTableAdapter.Fill(Me.Issue_Dataset.Issue)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        IssueBindingSource.AddNew()
        txtBorrowerID.Select()
      
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        On Error GoTo saveeror
        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            IssueBindingSource.EndEdit()
            IssueTableAdapter.Update(Issue_Dataset.Issue)
            BooksTableAdapter.Update(Books_Dataset.Books)
            StudentsTableAdapter.Update(Students_Dataset.Students)
            Me.IssueTableAdapter.Fill(Me.Issue_Dataset.Issue)
            Me.StudentsTableAdapter.Fill(Me.Students_Dataset.Students)
            Me.BooksTableAdapter.Fill(Me.Books_Dataset.Books)
            MessageBox.Show("Book Successfully Issued!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

saveeror:
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            IssueBindingSource.RemoveCurrent()

            IssueBindingSource.EndEdit()
            IssueTableAdapter.Update(Issue_Dataset.Issue)
            txtBorrowerID.Select()

            MessageBox.Show("Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Home_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Home_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        List_of_Students.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        List_of_Students.Show()
        Me.Hide()

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        List_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        List_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Return_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Return_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Missing_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Missing_of_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LogIn.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        IssueTableAdapter.Update(Issue_Dataset.Issue)
        BooksTableAdapter.Update(Books_Dataset.Books)
        StudentsTableAdapter.Update(Students_Dataset.Students)
        Me.IssueTableAdapter.Fill(Me.Issue_Dataset.Issue)
        Me.StudentsTableAdapter.Fill(Me.Students_Dataset.Students)
        Me.BooksTableAdapter.Fill(Me.Books_Dataset.Books)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.IssueBindingSource.Filter = "[BORROWER ID]  like '%" & txtBorrowerID.Text & "'"
    End Sub
End Class