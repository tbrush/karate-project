Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Date_Selector_ValueChanged(sender As Object, e As EventArgs) Handles Date_Selector.ValueChanged
        Try
            Me.MembersTableAdapter.FilterDate(KarateDataSet.Members, Date_Selector.Value.Date.ToShortDateString())
        Catch ex As Exception
            MessageBox.Show("Invalid date.")
        End Try
    End Sub
End Class
