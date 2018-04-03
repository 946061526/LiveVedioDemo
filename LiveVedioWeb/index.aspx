<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LiveVedioWeb._Index" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Button ID="BtnGet" runat="server" Text="获取直播信息" OnClick="BtnGet_Click" />  <asp:TextBox ID="TxtOnlineVedio" runat="server" Width="741px"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnGo" runat="server" Text="进行直播间" OnClick="BtnGo_Click" Width="161px" />
                <asp:Button ID="btnLinqToJson" runat="server" Text="linqToJson"  Width="161px" />
    
    </div>
</asp:Content>

