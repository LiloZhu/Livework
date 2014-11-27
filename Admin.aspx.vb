Public Class Admin
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Protected WithEvents Header As Header
    Protected WithEvents LeftMenu As New TreeFrame

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Context.User.IsInRole("Administrator") Or _
            Context.User.IsInRole("Packing Supervisor") Then
            Session.Item("current.page") = "admin"
        Else
            ' Live.util.WebComponent.JSAlert(Page, "You have no right to access this page")
        End If

    End Sub

    Private Sub MenuCall(ByVal xo As String) Handles Header.MenuItem
        Response.Write(xo)
        LeftMenu.MenuItems(xo)
    End Sub

End Class
