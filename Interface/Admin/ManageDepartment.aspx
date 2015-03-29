<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageDepartment.aspx.cs" Inherits="Admin_ManageDepartment" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

    <h1>Manage Departments</h1>    
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" /> --%>

       <table>
        <tr>
            <td><asp:DropDownList ID="DepartmentsDropDown" runat="server" Width="300px" DataSourceID="DepartmentsODS" DataTextField="DepartmentName" DataValueField="DepartmentCode" AutoPostBack="True" CausesValidation="True" ValidateRequestMode="Enabled" ValidationGroup="Please select Department">
                <asp:ListItem Enabled="False" Selected="True" Value="0">Please select Department</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button ID="LookupDepartmentButton" runat="server" Text="Lookup" OnClick="LookupDepartmentButton_Click" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Department Code:"></asp:Label></td>
            <td> <asp:TextBox ID="DepartmentCodeTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Department Name:"></asp:Label></td>
            <td><asp:TextBox ID="DepartmentNameTextBox" runat="server"></asp:TextBox> </td>
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
    <asp:Button ID="AddDepartmentButton" runat="server" Text="Create Department" OnClick="AddDepartmentButton_Click" />   
    <asp:Button ID="UpdateDepartmentButton" runat="server" Text="Update Department" OnClick="UpdateDepartmentButton_Click" />



    <asp:ObjectDataSource ID="DepartmentsODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Department_List" TypeName="Engine.BLL.DepartmentController"></asp:ObjectDataSource>
    
    </asp:Content>


