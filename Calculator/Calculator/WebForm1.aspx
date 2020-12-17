<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        	<asp:Label ID="Label1" runat="server" Text="Number1: "></asp:Label>
			<asp:TextBox ID="TxtNumber1" runat="server" Height="30px" style="margin-left: 5px" OnTextChanged="TxtNumber1_TextChanged"></asp:TextBox>
			<br />
			<asp:Label ID="Label2" runat="server" Text="Number2: "></asp:Label>
			<asp:TextBox ID="TxtNumber2" runat="server" Height="30px" style="margin-left: 5px" OnTextChanged="TxtNumber2_TextChanged"></asp:TextBox>
			<br />
			<asp:Label ID="Label3" runat="server" Text="Result: "></asp:Label>
			<asp:TextBox ID="ResultBox" runat="server" Height="30px" style="margin-left: 24px" OnTextChanged="ResultBox_TextChanged" ReadOnly="True"></asp:TextBox>
			<br />
			<br />
			<asp:Button ID="ButtonSum" runat="server" Height="30px" Text="+" Width="30px" OnClick="ButtonSum_Click" />
			<asp:Button ID="ButtonMinus" runat="server" Height="30px" style="margin-left: 25px" Text="-" Width="30px" OnClick="ButtonMinus_Click" />
			<asp:Button ID="ButtonMult" runat="server" Height="30px" style="margin-left: 25px" Text="*" Width="30px" OnClick="ButtonMult_Click" />
			<asp:Button ID="ButtonDivide" runat="server" Height="30px" style="margin-left: 25px" Text="/" Width="30px" OnClick="ButtonDivide_Click" />
			<asp:Button ID="ButtonClear" runat="server" Height="30px" style="margin-left: 25px" Text="Clear" Width="60px" OnClick="ButtonClear_Click" />

        </div>
    </form>
</body>
</html>
