Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace AGASPTemplates

    Public Class HeaderTemplate : Inherits Page

        Public SampleText As New Label()

        Private Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            Quicktext("<html><body>")
            SampleText.Text = "There is no content"
            Controls.Add(SampleText)
            Quicktext("</body></html>")
        End Sub

        Private Sub Quicktext(ByVal text As String)
            Controls.Add(New LiteralControl(text))
        End Sub

    End Class
End Namespace