<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormByEmployee.aspx.cs" Inherits="SearchHAForm_HAFormByEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    Search Form by Designate
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="HAFormByEmployee" DataTextField="FullName" DataValueField="EmployeeID">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
<asp:ObjectDataSource ID="HAFormByEmployee" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Employee_List" TypeName="Engine.BLL.SearchHAFormByEmployeeController"></asp:ObjectDataSource>
&nbsp;
</asp:Content>

