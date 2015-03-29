<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormBySchool.aspx.cs" Inherits="SearchHAForm_HAFormBySchool" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    Search Form by School&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="HAFormBySchool" DataTextField="School" DataValueField="PotentialHazardID">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
<asp:ObjectDataSource ID="HAFormBySchool" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="PotentialHazard_List" TypeName="Engine.BLL.SearchHAFormByPotentialHazardController"></asp:ObjectDataSource>
<br />
</asp:Content>

