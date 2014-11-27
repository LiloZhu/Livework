<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TreeFrameLimited.ascx.vb" Inherits="LiveWork.TreeFrameLimited" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>

<html>

<head>

<!-- if you want black backgound, remove this style block -->
<style>
   BODY {background-color: white}
   TD {font-size: 10pt; 
       font-family: verdana,helvetica; 
	   text-decoration: none;
	   white-space:nowrap;}
   A  {text-decoration: none;
       color: black}
   
    .specialClass {font-family:garamond; font-size:12pt;color:green;font-weight:bold;text-decoration:underline}
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
<script src="js/system/TreeLimited.js"></script>

</head>

<body topmargin=16 marginheight=16>

<!-- By making any changes to this code you are violating your user agreement.
     Corporate users or any others that want to remove the link should check 
	 the online FAQ for instructions on how to obtain a version without the link -->
<!-- Removing this link will make the script stop from working -->
<div style="position:absolute; top:0; left:0; "><table border=0><tr><td><font size=-2><a style="font-size:7pt;text-decoration:none;color:silver" href="http://www.treemenu.net/treemenu/userhelp.asp" target=_parent </a></font></td></tr></table></div>

<!-- Build the browser's objects and display default view of the 
     tree. -->
<script>initializeDocument()</script>
<noscript>
A tree for site navigation will open here if you enable JavaScript in your browser.
</noscript>

</html>

