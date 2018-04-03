<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LiveVedioAdmin._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <div>
        主播ID:<asp:TextBox ID="TxtUserID" runat="server" Text="teststream1"></asp:TextBox>
    </div>
    <div>
        禁播时长(分钟)：<asp:TextBox ID="TxtTime" runat="server" Text="1"></asp:TextBox>
        <asp:Button ID="BtnForbid" runat="server" Text="禁播" OnClick="BtnForbid_Click" />
        <asp:Button ID="BtnResume" runat="server" Text="恢复" OnClick="BtnResume_Click" />
    </div>

    <div>
        <asp:Button ID="BtnPublishList" runat="server" Text="查询推流历史" OnClick="BtnPublishList_Click"  />
        <asp:Button ID="BtnOnlineList" runat="server" Text="查询推流在线列表" OnClick="BtnOnlineList_Click"  />
        <asp:Button ID="BtnGetTotalUserNum" runat="server" Text="查询在线人数" OnClick="BtnGetTotalUserNum_Click"   />
    </div>
    <div>
        <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>

