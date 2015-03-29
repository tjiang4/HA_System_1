<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormByDepartment.aspx.cs" Inherits="SearchHAForm_HAFormByDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        Search Form by Program&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="HAFormByDepartment" DataTextField="DepartmentName" DataValueField="DepartmentCode">
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
        <asp:ObjectDataSource ID="HAFormByDepartment" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Department_List" TypeName="Engine.BLL.SearchHAFormByDepartmentController"></asp:ObjectDataSource>
    </p>
</asp:Content>

