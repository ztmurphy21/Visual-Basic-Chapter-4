' Name:         Mount Rushmore Project
' Purpose:      Display an appropriate message
' Programmer:   Zachary Murphy on 2-16-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' display an appropriate message

        Dim strName As String

        strName = txtName.Text.ToUpper

        'determines if name of person is on mount rushmore
        If strName = "GEORGE WASHINGTON" OrElse
                strName = "THOMAS JEFFERSON" OrElse
                strName = "ABRAHAM LINCOLN" OrElse
                strName = "THEODORE ROOSEVELT" Then
            lblMsg.Text = "On Mount Rushmore"
        Else
            lblMsg.Text = "Not on Mount Rushmore"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblMsg.Text = String.Empty
    End Sub
End Class
