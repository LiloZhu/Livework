<%@ Control Language="vb" AutoEventWireup="false" Codebehind="CalendarControl.ascx.vb" Inherits="LiveWork.CalendarControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:TextBox id="DateText1" runat="server"></asp:TextBox>
<INPUT type="button" value="..." onclick="OnClick()"><br>
<div id="divCalendar" style="DISPLAY: none; POSITION: absolute">
	<asp:Calendar id="Calendar1" runat="server" BorderWidth="2px" BackColor="White" Width="200px" ForeColor="Black" Height="180px" Font-Size="8pt" Font-Names="Verdana" BorderColor="#999999" BorderStyle="Outset" DayNameFormat="FirstLetter" CellPadding="4">
		<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
		<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
		<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
		<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#CCCCCC"></DayHeaderStyle>
		<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
		<TitleStyle Font-Bold="True" BorderColor="Black" BackColor="#999999"></TitleStyle>
		<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
		<OtherMonthDayStyle ForeColor="#808080"></OtherMonthDayStyle>
	</asp:Calendar>
</div>
<script>
function OnClick()
{
  if( divCalendar.style.display == "none")
    divCalendar.style.display = "";
  else
    divCalendar.style.display = "none";
}
</script>
