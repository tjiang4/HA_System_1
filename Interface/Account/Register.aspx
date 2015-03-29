<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create new Employee.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="EmployeeFirstNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

          <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="EmployeeLastNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Login Level</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="LoginLevDropDown" CssClass="form-control" runat="server" DataTextField="LogLev" DataValueField="LogLev">
                <asp:ListItem Value="CHAEHA">Create/Edit Hazard Assessment</asp:ListItem>
                <asp:ListItem Value="ADM">Administration</asp:ListItem>
                 <asp:ListItem Value="VO">Guest</asp:ListItem>
                </asp:DropDownList> 
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Employee Type</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="EmployeeTypeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Department Name</asp:Label>
            <div class="col-md-10">
                 <asp:DropDownList ID="DepartmentDropDown" CssClass="form-control" runat="server" DataSourceID="DepartmentODS" DataTextField="DepartmentName" DataValueField="DepartmentCode"></asp:DropDownList> </td>
            </div>
        </div>
                <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
          <asp:TextBox ID="EmployeeIDTextBox" runat="server" ReadOnly="true" Visible="false"></asp:TextBox>
     


            
          
     

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Create User" CssClass="btn btn-default" />
            </div>
        </div>
    </div>

    <asp:ObjectDataSource ID="DepartmentODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Department_List" TypeName="Engine.BLL.DepartmentController"></asp:ObjectDataSource>
</asp:Content>

