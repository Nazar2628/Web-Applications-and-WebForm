<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="FirstForm.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFCC">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="sid" runat="server" Text="ID"></asp:Label></td>
                    <td><asp:TextBox ID="id" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="name" runat="server" Text="Name"></asp:Label></td>
                    <td><asp:TextBox ID="sname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Email"></asp:Label></td>
                    <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                    <td><asp:TextBox ID="pass" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Age"></asp:Label></td>
                    <td><asp:TextBox ID="age" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="University"></asp:Label></td>
                    <td><asp:TextBox ID="uni" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Degree"></asp:Label></td>
                    <td><asp:TextBox ID="Degree" runat="server"></asp:TextBox></td>
                </tr>

            </table>
            <table>
                <tr>
                    <td><asp:Button ID="sinsert" Text="Insert" runat="server" OnClick="s_inserted" /></td>
                    <td><asp:Button ID="supdate" Text="Update" runat="server" OnClick="s_updated" /></td>
                    <td><asp:Button ID="Sdelete" Text="Delete" runat="server" OnClick="s_deleted" /></td>
                    <td><asp:Button ID="sread" Text="Read" runat="server" OnClick="s_read" /></td>
                    <td><asp:Button ID="sall" Text="Read All" runat="server" OnClick="s_all" /></td>
                    <td> Status : <asp:Label ID="status" runat="server"></asp:Label><br /></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:DataGrid ID="s_grid" runat ="server"></asp:DataGrid>
        </div>
    </form>
    </body>
</html>
