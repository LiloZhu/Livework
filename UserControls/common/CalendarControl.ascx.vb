Public MustInherit Class CalendarControl
    Inherits System.Web.UI.UserControl
    Protected WithEvents DateText1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        DateText1.Text = Calendar1.SelectedDate.ToShortDateString()
        Dim div As System.Web.UI.Control = Page.FindControl("divCalendar")

        If TypeOf div Is HtmlGenericControl Then
            CType(div, HtmlGenericControl).Style.Add("display", "none")
        End If
    End Sub

End Class
