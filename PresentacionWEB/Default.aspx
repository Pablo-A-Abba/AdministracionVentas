<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentacionWEB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>MercadeAbba</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>prueba 1</p>
            <asp:BulletedList ID="BLProveedor" runat="server">
                
            </asp:BulletedList>
        </div>
        <div class="col-md-4">
            <p>prueba 1</p>
        </div>
    </div>

</asp:Content>
 