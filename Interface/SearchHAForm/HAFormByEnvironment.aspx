<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormByEnvironment.aspx.cs" Inherits="SearchHAForm_HAFormByEnvironment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    Search Form by Environment&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="HAFormByEnvironment" DataTextField="EnvironmentName" DataValueField="EnvironmentID">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
<asp:ObjectDataSource ID="HAFormByEnvironment" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Environment_List" TypeName="Engine.BLL.SearchHAFormByEnvironmentController"></asp:ObjectDataSource>
&nbsp;
</asp:Content>

