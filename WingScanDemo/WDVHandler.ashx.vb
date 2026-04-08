Imports System
Imports System.Web
Imports Atalasoft.Imaging.WebControls

Public Class WDVHandler : Inherits WebDocumentRequestHandler
    Public Sub New()
        AddHandler Me.FileUpload, AddressOf fileUploadHandler
    End Sub

    ''' <summary>
    ''' NOTE we want to explicitly handle this and set e.Cancel to true to completely disable the file upload
    ''' this is because we're not using it in this demo and this is best practice to force the upload feature completely off from server side
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub fileUploadHandler(sender As Object, e As FileUploadEventArgs)
        e.Cancel = True
        e.Overwrite = False
    End Sub

End Class
