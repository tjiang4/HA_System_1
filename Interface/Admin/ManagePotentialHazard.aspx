<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManagePotentialHazard.aspx.cs" Inherits="Admin_ManagePotentialHazard" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

     <h1 class="adminTitle">Manage Potential Hazards</h1>
    <%--<input id="Create" type="button" value="Create a Department" /> &nbsp; &nbsp; <input id="Update" type="button" value="Lookup a Department" /> --%>

       <table>
        <tr>
            <td style="width: 377px"><asp:DropDownList ID="PotentialHazardsDropDown" runat="server" Width="300px" DataSourceID="PotentialHazardsODS" DataTextField="PotentialHazardName" DataValueField="PotentialHazardID">
                <asp:ListItem Enabled="False" Selected="True" Value="0">Please select Potential Hazards</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:Button CssClass="btn-default" ID="LookupPotentialHazardButton" runat="server" Text="Lookup" OnClick="LookupPotentialHazardButton_Click" Width="225px" /></td>
        </tr>
       </table>
    <br />
      <table>
        <tr>
            <td style="width: 377px"> <asp:TextBox ID="PotentialHazardIDTextBox" runat="server" Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 377px"><asp:Label ID="Label2" runat="server" Text="Potential Hazard Name:"></asp:Label></td>
            <td><asp:TextBox ID="PotentialHazardNameTextBox" runat="server" Width="225px"></asp:TextBox> </td>
        </tr>
          <tr>
            <td style="width: 377px"><asp:Label ID="Label3" runat="server" Text="Defination:"></asp:Label></td>
            <td><asp:TextBox ID="DefinationTextBox" runat="server" Width="225px"></asp:TextBox> </td>
        </tr>
          <tr>
            <td style="width: 377px"><asp:Label ID="Label4" runat="server" Text="School:"></asp:Label></td>
            <td><asp:TextBox ID="SchoolTextBox" runat="server" Width="225px"></asp:TextBox> </td>
        </tr>

       

        </table>
    <br /> 
    <asp:Button CssClass="btn-primary" ID="AddPotentialHazardButton" runat="server" Text="Create Potential Hazard" OnClick="AddPotentialHazardButton_Click" Height="35px" Width="225px" />   
    &nbsp;<asp:Button CssClass="btn-primary" ID="UpdatePotentialHazardButton" runat="server" Text="Update Potential Hazard" OnClick="UpdatePotentialHazardButton_Click" Height="35px" Width="225px" />



    <asp:ObjectDataSource ID="PotentialHazardsODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="PotentialHazard_List" TypeName="Engine.BLL.PotentialHazardController"></asp:ObjectDataSource>
    
</asp:Content>

