
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

folderLA = gFld("<strong><font color=black>Label Attribute</font></strong>", "")
	  insDoc(folderLA, gLnk("S", "<strong><font color=black>Mandatory</font></strong>", "LabelAttribute.aspx?page=man"))
	  insDoc(folderLA, gLnk("S", "<strong><font color=black>Customer Attribute</font></strong>", "LabelAttribute.aspx?page=cs"))

folderPC = gFld("<strong><font color=black>Print Customizer</font></strong>", "")
	  insDoc(folderPC, gLnk("S", "<strong><font color=black>Escape Code</font></strong>", "EscapeCode.aspx"))
	  insDoc(folderPC, gLnk("S", "<strong><font color=black>Device Map</font></strong>", "DeviceMap.aspx"))

 foldersXO = gFld("<strong><font color=black>XO</font></strong>", "")
	  insDoc(foldersXO, gLnk("S", "<strong><font color=black>Escape Code</font></strong>", "EscapeCode.aspx"))
	  insDoc(foldersXO, gLnk("S", "<strong><font color=black>Device Map</font></strong>", "DeviceMap.aspx"))

foldersTree = gFld("<strong><font color=black>System</font></strong>", "Admin.aspx")

      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Users</font></strong>", "Users.aspx"))
     // insDoc(foldersTree, gLnk("Z", "<strong>Roles</strong>", "sys_roles.html"))
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Packing Form</font></strong>", "PackForm.aspx"))
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Packing Method</font></strong>", "PackingMethod.aspx"))
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Label Formats</font></strong>", "LabelFormat.aspx"))
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Custom Labels</font></strong>", "CustomerLabel.aspx"))
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Customer Code</font></strong>", "CustomerCode.aspx"))
	  insDoc(foldersTree, folderLA)	  
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Spec</font></strong>", "Spec.aspx"))
	  insDoc(foldersTree, gLnk("S", "<strong><font color=black>Printer</font></strong>", "Printer.aspx"))
	  insDoc(foldersTree, folderPC)	  
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>WorkStation</font></strong>", "WorkStation.aspx"))
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Settings</font></strong>", "Settings.aspx")) 
      insDoc(foldersTree, gLnk("S", "<strong><font color=black>Logs</font></strong>", "Logs.aspx"))
      insDoc(foldersTree, foldersXO)