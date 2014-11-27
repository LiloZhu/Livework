<%@ Register TagPrefix="template" TagName="LeftMenu" Src="UserControls\system\TreeFrame.ascx" %>
<%@ Register TagPrefix="template" TagName="Header" Src="UserControls\common\Header.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Admin.aspx.vb" Inherits="LiveWork.Admin"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ASAT - System</title>
		<% System.Web.HttpContext.Current.Response.AddHeader("Cache-Control","no-cache")
System.Web.HttpContext.Current.Response.Expires = 0
System.Web.HttpContext.Current.Response.Cache.SetNoStore()
System.Web.HttpContext.Current.Response.AddHeader("Pragma", "no-cache")%>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%">
				<tr height="91">
					<td colSpan="2"><template:header id="Header" runat="server"></template:header>
					</td>
				</tr>
				<tr height="*">
					<td colSpan="2">
						<table cellSpacing="0" cellPadding="0" width="100%">
							<tr height="91">
								<td vAlign="top" width="170">
									<%	if Context.User.IsInRole("Administrator") then	%>
									<%	elseif Context.User.IsInRole("Packing Supervisor") then	%>
									<% else %>
									<template:leftmenu id="MenuFrame" runat="server" />
									<%	end if	%>
								</td>
								<td vAlign="top" align="left" width="*"><FONT face="ËÎÌו"></FONT>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
