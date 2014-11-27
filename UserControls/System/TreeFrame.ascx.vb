'Public MustInherit Class TreeFrame
Public Class TreeFrame
    Inherits System.Web.UI.UserControl

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
    Public idtb_main_menu As New DataTable
    Public idtb_menu_group As New DataTable
    Public idtb_menu As New DataTable

    Public main_menu As String
    Public menu_group As String
    Public sub_menu As String

    Public Sub SetMainMenuTable(ByVal adtb_main_menu As DataTable)
        idtb_main_menu = adtb_main_menu
    End Sub
    Public Function GetMainMenuTable() As DataTable
        Return Me.idtb_main_menu
    End Function

    Public Sub SetMenuGroupTable(ByVal adtb_menu_group As DataTable)
        idtb_menu_group = adtb_menu_group
    End Sub
    Public Function GetMenuGroupTable() As DataTable
        Return Me.idtb_menu_group
    End Function

    Public Sub SetMenuTable(ByVal adtb_menu As DataTable)
        idtb_menu = adtb_menu
    End Sub
    Public Function GetMenuTable() As DataTable
        Return Me.idtb_menu
    End Function

    Public Sub MenuItems(ByVal menu_id As String)
        Dim sql As String
        sql = "select * from tb_menu where main_menu_id='" & menu_id & "' "
        Dim ds As DataSet = Live.ado.ADOProxy.GetRowsByQuery(sql)
        SetMenuTable(ds.Tables(0))

        For lint_row As Integer = 0 To idtb_menu.Rows.Count - 1
            sub_menu += idtb_menu.Rows(lint_row).Item("menu_name").ToString() + "|"
        Next

    End Sub


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        For lint_row As Integer = 0 To idtb_menu.Rows.Count - 1
            sub_menu += idtb_menu.Rows(lint_row).Item("menu_name").ToString() + "|"
        Next

    End Sub

End Class


