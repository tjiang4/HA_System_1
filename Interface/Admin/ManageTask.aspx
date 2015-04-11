<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageTask.aspx.cs" Inherits="Admin_ManageTask" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

    <h1 class="adminTitle">Manage Tasks</h1>
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" />--%>

       <table>
        <tr>
            <td style="width: 376px"><asp:DropDownList ID="TasksDropDown" runat="server" Width="300px" DataSourceID="TasksODS" DataTextField="TaskName" DataValueField="TaskID">
                <asp:ListItem Enabled="False" Selected="True" Value="0">Please select Task</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button CssClass="btn-default" ID="LookupTaskButton" runat="server" Text="Lookup" OnClick="LookupTaskButton_Click" Width="200px" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td style="width: 376px"> <asp:TextBox ID="TaskIDTextBox" runat="server" Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 376px"><asp:Label ID="Label2" runat="server" Text="Task Name:"></asp:Label></td>
            <td><asp:TextBox ID="TaskNameTextBox" runat="server" Width="200px"></asp:TextBox> </td>
        </tr>

        <tr>
            <td style="width: 376px"><asp:Label ID="Label3" runat="server" Text="Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ActiveDropDown" runat="server" DataTextField="Active_YN" DataValueField="Active_YN" Height="26px" Width="200px">
                <asp:ListItem Value="Y">Active</asp:ListItem>
                <asp:ListItem Value="N">Inactive</asp:ListItem>
                </asp:DropDownList> 

            </td>
        </tr>

        </table>
    <br /> 
    <asp:Button CssClass="btn-primary" ID="AddTaskButton" runat="server" Text="Create Task" OnClick="AddTaskButton_Click" Height="35px" Width="200px" />   
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
    <asp:Button CssClass="btn-primary" ID="UpdateTaskButton" runat="server" Text="Update Task" OnClick="UpdateTaskButton_Click" Height="35px" Width="200px" />



    <asp:ObjectDataSource ID="TasksODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="HazardTask_List" TypeName="Engine.BLL.HazardTaskController"></asp:ObjectDataSource>
    
</asp:Content>

