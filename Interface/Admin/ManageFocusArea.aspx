<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageFocusArea.aspx.cs" Inherits="Admin_ManageFocusArea" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

     <h1>Manage Focus Areas</h1>
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" /> --%>

       <table>
        <tr>
            <td><asp:DropDownList ID="FocusAreasDropDown" runat="server" Width="300px" DataSourceID="FocusAreasODS" DataTextField="FocusAreaName" DataValueField="FocusAreaID">
                <asp:ListItem Enabled="False" Selected="True" Value="0">Please select Focus area</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button ID="LookupFocusAreaButton" runat="server" Text="Lookup" OnClick="LookupFocusAreatButton_Click" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td> <asp:TextBox ID="FocusAreaIDTextBox" runat="server" Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="FocusArea Name:"></asp:Label></td>
            <td><asp:TextBox ID="FocusAreaNameTextBox" runat="server"></asp:TextBox> </td>
        </tr>

        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ActiveDropDown" runat="server" DataTextField="Active_YN" DataValueField="Active_YN">
                <asp:ListItem Value="Y">Active</asp:ListItem>
                <asp:ListItem Value="N">Inactive</asp:ListItem>
                </asp:DropDownList> 

              <%--  <asp:TextBox ID="ActiveTextBox" runat="server"></asp:TextBox>--%>

            </td>
        </tr>

        </table>
    <br /> 
    <asp:Button ID="AddFocusAreaButton" runat="server" Text="Create FocusArea" OnClick="AddFocusAreaButton_Click" />   
    <asp:Button ID="UpdateFocusAreaButton" runat="server" Text="Update FocusArea" OnClick="UpdateFocusAreaButton_Click" />



    <asp:ObjectDataSource ID="FocusAreasODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="FocusArea_List" TypeName="Engine.BLL.FocusAreaController"></asp:ObjectDataSource>
    

    </asp:Content>

