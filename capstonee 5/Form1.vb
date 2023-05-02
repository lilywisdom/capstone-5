'Name: Hell & Taxes Inc
'Purpose: Search and display investors
'Programmer: Lily Woodworth Wisdom on 3/15/23

Option Strict On
Option Infer Off
Option Explicit On

Imports System.IO

Public Class frmMain
    Dim filepath As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        Open.CheckFileExists = True
        Open.Title = "OpenFile"
        Open.ShowDialog(Me)

        Try
            Open.OpenFile()
            For Each line As String In File.ReadAllLines(Open.FileName)
                lstFileRead.Items.Add(line)
                If IsNumeric(line) Then
                Else
                    lstNames.Items.Add(text)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        filepath = Open.FileName
        Open.OpenFile.Close()
    End Sub

    Private Sub btnGetInfo_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        Dim investIndex As Integer = lstNames.SelectedIndex * 3
        lblAmountNum.Text = lstFileRead.Items(investIndex).ToString
        lblPercentNum.Text = lstFileRead.Items(investIndex).ToString
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim a As Integer = 0
        a = lstNames.SelectedIndex * 3

        For intCount As Integer = 0 To 2
            lstFileRead.Items.RemoveAt(a)
        Next

        lstNames.Items.RemoveAt(lstNames.SelectedIndex)

        lblNum.Text = lstNames.Items.Count.ToString
    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblNum.Text = lstNames.Items.Count.ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstFileRead.Items.Add(txtName.Text)
        lstFileRead.Items.Add(txtAmount.Text)
        lstFileRead.Items.Add(txtPercent.Text)

        lstNames.Items.Add(txtName.Text)

        File.AppendAllText(filepath,
                txtName.Text & ControlChars.NewLine &
                txtAmount.Text & ControlChars.NewLine &
                txtPercent.Text & ControlChars.NewLine
            )

        txtAmount.Text = String.Empty
        txtName.Text = String.Empty
        txtPercent.Text = String.Empty
    End Sub

    Private Sub SaveClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveClearToolStripMenuItem.Click
        lstNames.Items.Clear()
        lstFileRead.Items.Clear()
        lblAmountNum.Text = String.Empty
        lblPercentNum.Text = String.Empty
    End Sub
End Class
