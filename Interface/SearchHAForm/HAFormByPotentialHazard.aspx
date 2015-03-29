<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HAFormByPotentialHazard.aspx.cs" Inherits="SearchHAForm_HAFormByPotentialHazard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        
    Search Form by Potential Hazard&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="HAFormByPotentialHazard" DataTextField="PotentialHazardName" DataValueField="PotentialHazardID">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LookUp" />
<asp:ObjectDataSource ID="HAFormByPotentialHazard" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="PotentialHazard_List" TypeName="Engine.BLL.SearchHAFormByPotentialHazardController"></asp:ObjectDataSource>
&nbsp;
        
</asp:Content>

