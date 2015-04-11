<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageEmployee.aspx.cs" Inherits="Admin_ManageEmployee" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

    <h1 class="adminTitle">Manage Employees</h1>
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" /> --%>

       <table>
        <tr>
            <td style="width: 389px"><asp:DropDownList ID="EmployeesDropDown" runat="server" Width="300px" DataSourceID="EmployeeODS" DataTextField="FullName" DataValueField="EmployeeID">
                <asp:ListItem Enabled="False" Selected="True" Value="0">Please select Employee</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button CssClass="btn-default" ID="LookupEmployeeButton" runat="server" Text="Lookup" OnClick="LookupEmployeeButton_Click" Width="215px" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td style="width: 389px"><asp:Label ID="Label1" runat="server" Text="Employee ID:"></asp:Label></td>
            <td> <asp:TextBox  ID="EmployeeIDTextBox" runat="server" ReadOnly="true" Width="215px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 389px"><asp:Label ID="Label2" runat="server" Text="Employee First Name:"></asp:Label></td>
            <td><asp:TextBox ID="EmployeeFirstNameTextBox" runat="server" Width="215px"></asp:TextBox> </td>
        </tr>
            <tr>
            <td style="width: 389px"><asp:Label ID="Label4" runat="server" Text="Employee Last Name:"></asp:Label></td>
            <td> <asp:TextBox ID="EmployeeLastNameTextBox" runat="server" Width="215px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 389px"><asp:Label ID="Label5" runat="server" Text="Login Level:"></asp:Label></td>
            <td> <asp:DropDownList ID="LoginLevDropDown" runat="server" DataTextField="LogLev" DataValueField="LogLev" Height="20px" Width="215px">
                <asp:ListItem Value="CHAEHA">Create/Edit Hazard Assessment</asp:ListItem>
                <asp:ListItem Value="ADM">Administration</asp:ListItem>
                 <asp:ListItem Value="VO">Guest</asp:ListItem>
                </asp:DropDownList> 
 </td>
        </tr>
            <tr>
            <td style="width: 389px"><asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label></td>
            <td> <asp:TextBox ID="EmailTextBox" runat="server" Width="215px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 389px"><asp:Label ID="Label7" runat="server" Text="Password:"></asp:Label></td>
            <td><asp:TextBox ID="PasswordTextBox" runat="server" Width="215px"></asp:TextBox> </td>
        </tr>
            <tr>
            <td style="width: 389px"><asp:Label ID="Label8" runat="server" Text="Employee Type:"></asp:Label></td>
            <td> <asp:TextBox ID="EmployeeTypeTextBox" runat="server" Width="215px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 389px"><asp:Label ID="Label9" runat="server" Text="Department Name:"></asp:Label></td>
            <td>
                <asp:DropDownList ID="DepartmentDropDown" runat="server" DataSourceID="DepartmentODS" DataTextField="DepartmentName" DataValueField="DepartmentCode" Height="22px" Width="215px"></asp:DropDownList> </td>
            
        </tr>


        </table>
    <br /> 
    <asp:Button CssClass="btn-primary" ID="UpdateEmployeeButton" runat="server" Text="Update Employee" OnClick="UpdateEmployeeButton_Click" Height="35px" Width="190px" />



    <asp:ObjectDataSource ID="EmployeeODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Employee_List" TypeName="Engine.BLL.EmployeeController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="DepartmentODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Department_List" TypeName="Engine.BLL.DepartmentController"></asp:ObjectDataSource>
    </asp:Content>


