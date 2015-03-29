<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManagePerformer.aspx.cs" Inherits="Admin_ManagePerformer" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />
      <h1>Manage Performers</h1>

       <table>
        <tr>
            <td><asp:DropDownList ID="PerformerDropDown" runat="server" Width="300px" DataSourceID="PerformersODS" DataTextField="PerformerName" DataValueField="PerformerID">
                <asp:ListItem Enabled="False" Selected="True" Value="0">Please select Performer</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button ID="LookupPerformerButton" runat="server" Text="Lookup" OnClick="LookupPerformerButton_Click" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td> <asp:TextBox ID="PerformerIDTextBox" runat="server" Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Performer Name:"></asp:Label></td>
            <td><asp:TextBox ID="PerformerNameTextBox" runat="server"></asp:TextBox> </td>
        </tr>

        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ActiveDropDown" runat="server" DataTextField="Active_YN" DataValueField="Active_YN">
                <asp:ListItem Value="Y">Active</asp:ListItem>
                <asp:ListItem Value="N">Inactive</asp:ListItem>
                </asp:DropDownList> 


            </td>
        </tr>

        </table>
    <br /> 
    <asp:Button ID="AddPerformerButton" runat="server" Text="Create Performer" OnClick="AddPerformerButton_Click" />   
    <asp:Button ID="UpdatePerformerButton" runat="server" Text="Update Performer" OnClick="UpdatePerformerButton_Click" />



    <asp:ObjectDataSource ID="PerformersODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Performer_List" TypeName="Engine.BLL.PerformerController"></asp:ObjectDataSource>
    

</asp:Content>

