﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="InClass11142024.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lbPizzaCompanies" runat="server" ></asp:ListBox>
            <br />
            <asp:Button ID="cmdSelectPizzaCompany" runat="server" Text="Select a Pizza Company" OnClick="cmdSelectPizzaCompany_Click"/>
            <br />
            <asp:Label ID="lblSelectedPizzaCompany" runat="server" Text=""></asp:Label>
            <br />
            <asp:CheckBoxList ID="cblIngredients" runat="server" />
            
        </div>
    </form>
</body>
</html>
