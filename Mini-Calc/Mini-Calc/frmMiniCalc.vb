Public Class frmMiniCalc
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue1.Text = ""
        txtValue2.Text = ""
        txtResult.Text = ""
        txtValue1.Select()

    End Sub

    Private Sub frmMiniCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        Dim value1 As Double
        Dim value2 As Double
        Dim result As Double

        value1 = txtValue1.Text

        value2 = txtValue2.Text

        result = value1 - value2

        txtResult.Text = value1 & " minus " & value2 & " equals " & result & Environment.NewLine & txtResult.Text
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Mini Calculator" & Environment.NewLine & "(c) 2019 College of Dupage" & Environment.NewLine & "Allrights Reserved")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim value1 As Double
        Dim value2 As Double
        Dim result As Double

        value1 = txtValue1.Text

        value2 = txtValue2.Text

        result = value1 + value2

        txtResult.Text = value1 & " plus " & value2 & " equals " & result & Environment.NewLine & txtResult.Text

    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        Dim value1 As Double
        Dim value2 As Double
        Dim result As Double

        value1 = txtValue1.Text

        value2 = txtValue2.Text

        result = value1 * value2

        txtResult.Text = value1 & " multiplied " & value2 & " equals " & result & Environment.NewLine & txtResult.Text
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Dim value1 As Double
        Dim value2 As Double
        Dim result As Double

        value1 = txtValue1.Text

        value2 = txtValue2.Text

        result = value1 / value2

        txtResult.Text = value1 & " divided by " & value2 & " equals " & result & Environment.NewLine & txtResult.Text
    End Sub


End Class
