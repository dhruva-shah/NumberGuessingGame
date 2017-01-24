<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPageSeparated.aspx.cs" Inherits="WebPageSeparated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html{
            background-color:white;
            align-content:center;
            align-items:center;
            align-self:center;
            font-weight:700;
            }
    </style>
 
</head>
 <body>
     <form id="form1" runat="server">
     <div style="align-content:center; align-items:center; align-self:center;" id="div">
         &nbsp;<br />
         <br />
         <asp:Panel ID="Panel2" runat="server">
             Enter nickname:&nbsp;
             <asp:TextBox ID="nameLabel" runat="server" Height="16px" Width="216px"></asp:TextBox>
             &nbsp;&nbsp;
             <br />
             <asp:Label ID="nonameLabel" runat="server" Text="Label" Visible="False"></asp:Label>
             <br />
             <br />
             <asp:Button ID="startGame" runat="server" BackColor="#99FFCC" Height="57px" OnClick="startGame_Click" Text="Start game!" Width="449px" />
         </asp:Panel>
         <br />
         <br />



     </div>
         <asp:Panel ID="Panel1" runat="server" Height="408px" style="margin-top: 0px" BackColor="#99FFCC" Visible="False">
             <asp:Label ID="hiLabel" runat="server"  BackColor="Transparent" ForeColor="#990099" Text="Label" Visible="False"></asp:Label>
             <br />
             <br />
             Guess the number!&nbsp;&nbsp;
             <asp:TextBox ID="numBox" runat="server" Width="35px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:Button ID="numButton" runat="server" BackColor="#990099" Text="Done" Width="64px" OnClick="numButton_Click" ForeColor="#99FFCC" />
             <br />
             <br />
             <br />
             <asp:Label ID="hllabel" runat="server" Text="Label" Visible="False"></asp:Label>
             <br />
             <br />
             <asp:Label ID="trys" runat="server" Text="Label" Visible="False"></asp:Label>
             <br />
             <br />
             <asp:Label ID="scorelabel" runat="server" Text="Label" Visible="False"></asp:Label>
             <br />
             <br />
             <asp:Label ID="hsLabel" runat="server" Text="Label" Visible="False"></asp:Label>
         </asp:Panel>
         <p>
             <asp:Button ID="again" runat="server" BackColor="#99FFCC" OnClick="Button1_Click" Text="Play again!" Visible="False" Width="1043px" />
         </p>
     </form>
     </body>
</html>
