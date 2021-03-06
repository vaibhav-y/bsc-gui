﻿Public Class CtlOutputFile
    Public Event OutFileSelected(ByVal outFileName As String)
    Dim outFileName As String

    ' Proxy Init Module
    Private Sub ctlOutputFile_Initialize()
        outFileName = Nothing
    End Sub

    ' Textbox handler
    Private Sub txtOutFile_TextChanged(sender As Object, e As EventArgs) Handles txtOutFile.TextChanged
        outFileName = txtOutFile.Text
    End Sub
    ' End Handler

    ' File Save button handler
    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOutFile.Text = saveFileDialog.FileName
            outFileName = txtOutFile.Text
        End If
    End Sub
    ' End Handler
End Class
