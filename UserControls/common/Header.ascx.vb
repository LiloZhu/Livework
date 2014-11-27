Public Class Header
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents M_Collection As System.Web.UI.WebControls.Button
    Protected WithEvents M_System As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Public Event MenuItem(ByVal lint_menu As String)

    Private Enum Menu
        System = 0
        Collection = 1
    End Enum

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not IsPostBack Then
            Session.Add("Menu", Menu.System)
        End If

    End Sub

    Private Sub M_System_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_System.Click
        SetMenuFocus(Menu.System)
        RaiseEvent MenuItem(Menu.System)
    End Sub

    Private Sub _Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Collection.Click
        SetMenuFocus(Menu.Collection)
        Session.Remove("Menu")
        Session.Add("Menu", Menu.Collection)
    End Sub

    Private Sub SetMenuFocus(ByVal menu_flag As Menu)
        Me.M_System.BackColor = System.Drawing.Color.SandyBrown
        Me.M_Collection.BackColor = System.Drawing.Color.SandyBrown
        Select Case menu_flag
            Case Menu.System
                M_System.BackColor = System.Drawing.Color.Salmon
            Case Menu.Collection
                M_Collection.BackColor = System.Drawing.Color.Salmon
        End Select
    End Sub

    Private Sub GetMainMenuId()

    End Sub

End Class
