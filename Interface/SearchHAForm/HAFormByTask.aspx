<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormByTask.aspx.cs" Inherits="SearchHAForm_HAFormByTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    Search Form by Task&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="HAFormByTask" DataTextField="TaskName" DataValueField="TaskID">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
<asp:ObjectDataSource ID="HAFormByTask" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Task_List" TypeName="Engine.BLL.SearchHAFormByTaskController"></asp:ObjectDataSource>
&nbsp;
</asp:Content>

