<%@ Page Title="SEB Project" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SEBProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div>
            <h1>Foodies</h1>
            <p>Where foodies share their love for the greater good</p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/pngwing.com(1).png" Height="300px" Width="403px" />
        </div>
    </div>

    <div class="row">
        <div class="body-content">
            <h2>Our Couse</h2>
            <p>
                Foodie is helping the fight againts famine & food waste around the world by giving amazing deals on product close to expiring products and the chance to donate 
            </p>
        </div>

        <div class="body-content">
            <h2>Treat yourself with something tasty</h2>
            <p>
                Foodie let's you order everything your tummy is craving from top-tier restaurants with only a few steps
            </p>
        </div>
    </div>


</asp:Content>
