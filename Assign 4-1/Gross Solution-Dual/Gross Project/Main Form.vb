' Name:         Gross Project
' Purpose:      Displays gross pay
' Programmer:   Zach Murphy on 2-16-2017

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate gross pay

        Dim decHours As Decimal
        Dim decRate As Decimal
        Dim decGross As Decimal

        Decimal.TryParse(txtHours.Text, decHours)
        Decimal.TryParse(txtRate.Text, decRate)

        If decHours <= 40 Then
            ' regular pay
            decGross = decHours * decRate
        Else
            ' add overtime, if appropriate
            decGross = decHours * decRate + (decHours - 40) * decRate / 2
        End If

        lblGross.Text = decGross.ToString("c2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearGross(sender As Object, e As EventArgs) Handles txtHours.TextChanged, txtRate.TextChanged
        lblGross.Text = String.Empty
    End Sub
End Class
