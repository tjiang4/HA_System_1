<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Search Archived</h1>
    <table>
        <tr>
            <td>Search by Focus Area</td>
            <td><asp:DropDownList ID="FocusAreaDropDown" runat="server" DataSourceID="FocusAreaODS" DataTextField="FocusAreaName" DataValueField="FocusAreaID"></asp:DropDownList>

            </td>  
            <td>
            <asp:Button ID="LookupFocusArea_Click" runat="server" Text="Search" />
            </td>
            
        </tr>
    </table>
    <asp:GridView ID="FocusAreaGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataSourceID="ObjectDataSource1">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="FocusAreaName" HeaderText="FocusAreaName" SortExpression="FocusAreaName" />
            <asp:BoundField DataField="TaskName" HeaderText="TaskName" SortExpression="TaskName" />
            <asp:BoundField DataField="SignOffDate" HeaderText="SignOffDate" SortExpression="SignOffDate" />
            <asp:BoundField DataField="CreatorFirstName" HeaderText="CreatorFirstName" SortExpression="CreatorFirstName" />
            <asp:BoundField DataField="CreatorLastName" HeaderText="CreatorLastName" SortExpression="CreatorLastName" />
            <asp:BoundField DataField="ApprovedBy" HeaderText="ApprovedBy" SortExpression="ApprovedBy" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <EmptyDataTemplate>
            No data to display.
        </EmptyDataTemplate>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:Label ID="MesssageLabel" runat="server" Text=""></asp:Label>
    <asp:ObjectDataSource ID="FocusAreaODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="FocusArea_List" TypeName="Engine.BLL.FocusAreaController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SearchHAByFocusArea" TypeName="Engine.BLL.SearchArchive">
        <SelectParameters>
            <asp:ControlParameter ControlID="FocusAreaDropDown" DefaultValue="0" Name="FocusAreaID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
