<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormByFocusArea.aspx.cs" Inherits="SearchHAForm_HAFormByFocusArea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    Search Form by Focus Area&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="HAFormByFocusArea" DataTextField="FocusAreaName" DataValueField="FocusAreaID">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
<asp:ObjectDataSource ID="HAFormByFocusArea" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="FocusArea_List" TypeName="Engine.BLL.SearchHAFormByFocusAreaController"></asp:ObjectDataSource>
&nbsp;
</asp:Content>

