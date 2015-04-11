<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageEnvironment.aspx.cs" Inherits="Admin_ManageEnvironment" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

<h1 class="adminTitle">Manage Environment</h1>
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" /> --%>

       <table>
        <tr>
            <td style="width: 410px"><asp:DropDownList ID="EnvironmentsDropDown" runat="server" Width="300px" DataSourceID="EnvironmentsODS" DataTextField="EnvironmentName" DataValueField="EnvironmentID">
                <asp:ListItem Selected="True">Please select Environment</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button CssClass="btn-default" ID="LookupEnvironmentButton" runat="server" Text="Lookup" OnClick="LookupEnvironmentButton_Click" Width="200px" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td style="width: 410px"> <asp:TextBox ID="EnvironmentIDTextBox" runat="server" Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 410px"><asp:Label ID="Label2" runat="server" Text="Environment Name:"></asp:Label></td>
            <td><asp:TextBox ID="EnvironmentNameTextBox" runat="server" Width="200px"></asp:TextBox> </td>
        </tr>

        <tr>
            <td style="width: 410px"><asp:Label ID="Label3" runat="server" Text="Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList  ID="ActiveDropDown" runat="server" DataTextField="Active_YN" DataValueField="Active_YN" Height="26px" Width="200px">
                <asp:ListItem Value="Y">Active</asp:ListItem>
                <asp:ListItem Value="N">Inactive</asp:ListItem>
                </asp:DropDownList> 

              <%--  <asp:TextBox ID="ActiveTextBox" runat="server"></asp:TextBox>--%>

            </td>
        </tr>

        </table>
    <br /> 
    <asp:Button CssClass="btn-primary" ID="AddEnvironmentButton" runat="server" Text="Create Environment" OnClick="AddEnvironmentButton_Click" Height="35px" Width="200px" />    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
    <asp:Button CssClass="btn-primary" ID="UpdateEnvironmentButton" runat="server" Text="Update Environment" OnClick="UpdateEnvironmentButton_Click" Height="35px" Width="200px" />



    <asp:ObjectDataSource ID="EnvironmentsODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Environ_List" TypeName="Engine.BLL.EnvironController"></asp:ObjectDataSource>
    
    </asp:Content>
 
