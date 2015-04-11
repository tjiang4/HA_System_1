<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageFocusArea.aspx.cs" Inherits="Admin_ManageFocusArea" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

     <h1 class="adminTitle">Manage Focus Areas</h1>
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" /> --%>

       <table>
        <tr>
            <td style="width: 388px">s</td>
            <td><asp:Button CssClass="btn-default" ID="LookupFocusAreaButton" runat="server" Text="Lookup" OnClick="LookupFocusAreatButton_Click" Width="190px" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td style="width: 389px"> <asp:TextBox ID="FocusAreaIDTextBox" runat="server" Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 389px"><asp:Label ID="Label2" runat="server" Text="FocusArea Name:"></asp:Label></td>
            <td><asp:TextBox ID="FocusAreaNameTextBox" runat="server" Width="190px"></asp:TextBox> </td>
        </tr>

        <tr>
            <td style="width: 389px"><asp:Label ID="Label3" runat="server" Text="Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ActiveDropDown" runat="server" DataTextField="Active_YN" DataValueField="Active_YN" Height="22px" Width="190px">
                <asp:ListItem Value="Y">Active</asp:ListItem>
                <asp:ListItem Value="N">Inactive</asp:ListItem>
                </asp:DropDownList> 

              <%--  <asp:TextBox ID="ActiveTextBox" runat="server"></asp:TextBox>--%>

            </td>
        </tr>

        </table>
    <br /> 
    <asp:Button CssClass="btn-primary" ID="AddFocusAreaButton" runat="server" Text="Create FocusArea" OnClick="AddFocusAreaButton_Click" Height="35px" Width="190px" />   
    <asp:Button CssClass="btn-primary" ID="UpdateFocusAreaButton" runat="server" Text="Update FocusArea" OnClick="UpdateFocusAreaButton_Click" Height="35px" Width="190px" />



    <asp:ObjectDataSource ID="FocusAreasODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="FocusArea_List" TypeName="Engine.BLL.FocusAreaController"></asp:ObjectDataSource>
    

    </asp:Content>

