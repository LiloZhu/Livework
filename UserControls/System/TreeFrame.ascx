<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TreeFrame.ascx.vb" Inherits="LiveWork.TreeFrame" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>

<HTML>
  <HEAD>

<!-- if you want black backgound, remove this style block -->
<style>BODY { BACKGROUND-COLOR: white }
	TD { FONT-SIZE: 10pt; FONT-FAMILY: verdana,helvetica; WHITE-SPACE: nowrap; TEXT-DECORATION: none }
	A { COLOR: black; TEXT-DECORATION: none }
	.specialClass { FONT-WEIGHT: bold; FONT-SIZE: 12pt; COLOR: green; FONT-FAMILY: garamond; TEXT-DECORATION: underline }
	</style>
<!-- if you want black backgound, remove this line and the one marked XXXX and keep the style block below 

<style>
   BODY {background-color: black}
   TD {font-size: 10pt; 
       font-family: verdana,helvetica 
	   text-decoration: none;
	   white-space:nowrap;}
   A  {text-decoration: none;
       color: white}
</style>
XXXX -->



<!-- NO CHANGES PAST THIS LINE -->


<!-- Code for browser detection -->
<script src="js/system/ua.js"></script>

<!-- Infrastructure code for the tree -->
<script src="js/system/ftiens4.js"></script>

<!-- Execution of the code that actually builds the specific tree.
     The variable foldersTree creates its structure with calls to
	 gFld, insFld, and insDoc -->
<!--wzhu modified by 2007-01-11- script src="js/system/Tree.js"></script  wzhu modified by 2007-01-11-->
<script>
// Decide if the names are links or just the icons
USETEXTLINKS = 1  //replace 0 with 1 for hyperlinks

// Decide if the tree is to start all open or just showing the root folders
STARTALLOPEN = 0 //replace 0 with 1 to show the whole tree

USEFRAMES = 1

PERSERVESTATE = 1

HIGHLIGHT = 1
HIGHLIGHT_COLOR = 'blue'
var HIGHLIGHT_BG    = 'white'

ICONPATH = 'images/' //change if the gif's folder is a subfolder, for example: 'images/'


foldersTree = gFld("<strong><font color=black>System</font></strong>", "Admin.aspx")

    var lint_menu_group_count=<%=idtb_menu_group.rows.count()%>
   	var lint_menu_rows_count=<%=idtb_menu.rows.count()%>
    var menu="<%=sub_menu%>";   
    var sarray=new Array();   
    marray=menu.split('|');  
	for(var lint_row=0;lint_row<lint_menu_rows_count;lint_row++)
	{
	  insDoc(foldersTree, gLnk("S", "<strong><font color=black>"+ marray[lint_row] +"</font></strong>", "xxxx"))
	} 	

	var tempforlder=""

   
</script>
</HEAD>
<body topMargin=16 marginheight="16">

<!-- By making any changes to this code you are violating your user agreement.
     Corporate users or any others that want to remove the link should check 
	 the online FAQ for instructions on how to obtain a version without the link -->
<!-- Removing this link will make the script stop from working -->
<div style="LEFT: 0px; POSITION: absolute; TOP: 0px">
<table border=0>
  <tr>
    <td><font size=-2><a 
      style="FONT-SIZE: 7pt; COLOR: silver; TEXT-DECORATION: none" 
      href="http://www.treemenu.net/treemenu/userhelp.asp" target=_parent 
       a <></font></A></td></tr></table></div>

<!-- Build the browser's objects and display default view of the 
     tree. -->
<script>initializeDocument()</script>
<noscript>A tree for site navigation will open here if you 
enable JavaScript in your browser. </noscript></body>
</HTML>
