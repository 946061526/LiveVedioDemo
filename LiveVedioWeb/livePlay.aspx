<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="livePlay.aspx.cs" Inherits="LiveVedioWeb._LivePlay" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div id="vedioPlayer" class="prism-player"></div>
    <asp:HiddenField ID="hidUrl" runat="server" />
    <script>
        // 初始化播放器
        var url = 'http://imlive.1yyg.com/1yyg/1000319320_201707071455043616.m3u8';// document.getElementById('MainContent_hidUrl').value;
        //url = 'http://cloud.video.taobao.com/play/u/2554695624/p/1/e/6/t/1/fv/102/28552077.mp4';

        var player = new prismplayer({
            id: "vedioPlayer", // 容器id
            source: url,// 视频地址
            autoplay: false,    //自动播放：否
            width: "500px",       // 播放器宽度
            height: "400px"      // 播放器高度
        });
    </script>

</asp:Content>
