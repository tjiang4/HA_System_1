<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <h1>Hazard Assessment System</h1>
        <p class="lead">A comprehensive Hazard Assessment reporting system for the Northern Alberta Institute of Technology.</p>
        <div class="function-desc">
        <img src="icon01.png" alt="Alternate Text" height="55"/>
        <h4>Content Management</h4>
        <p>Supports the creating, editing, and publishing information.</p>
        </div>
        <div class="function-desc">
        <img src="icon02.png" alt="Alternate Text" height="55"/>
        <h4>Create Form</h4>
        <p>Create Hazard Assessment Form when logged in</p>
        </div>
        <div class="function-desc">
        <img src="icon03.png" alt="Alternate Text" height="55"/>
        <h4>Search Forms</h4>
        <p>Search both archived and unarchived forms </p>
        </div>
    </div>

</asp:Content>
