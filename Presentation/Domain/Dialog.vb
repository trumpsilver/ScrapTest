﻿Imports MaterialDesignThemes.Wpf
Namespace Domain
    Public Module Dialog
        Public Async Sub Show(ByVal content As String)
            Dim messageDialog As New MessageDialog
            messageDialog.Message.Text = content
            Await DialogHost.Show(messageDialog)
        End Sub
        Public Async Sub ShowUserControl(ByVal content As Object)
            Await DialogHost.Show(content)
        End Sub
    End Module
End Namespace
