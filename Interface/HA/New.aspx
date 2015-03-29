<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="New.aspx.cs" Inherits="HazardAssessment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1>Create New Hazard Assessment Form</h1>
      <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Task Assessed:"></asp:Label></td>
            <td> <asp:TextBox ID="TaskAssessedTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Task for:"></asp:Label></td>
            <td> <asp:DropDownList ID="HATaskDropDown" runat="server" DataSourceID="HATaskODS" DataTextField="TaskName" DataValueField="TaskID"></asp:DropDownList></td>
        </tr>
          
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Department/Program:"></asp:Label></td>
            <td><asp:ListView ID="ListView3" runat="server" DataSourceID="DepartmentODS">
                    <ItemTemplate>
                            <asp:Label ID="FullNameLabel" runat="server" Text='<%# Eval("DepartmentCode") %>' />
                    </ItemTemplate>
                </asp:ListView>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label4" runat="server" Text="HA Completed by:"></asp:Label></td>
            <td> <asp:ListView ID="ListView2" runat="server" DataSourceID="ApprovedODS">
                    <ItemTemplate>
                            <asp:Label ID="FullNameLabel" runat="server" Text='<%# Eval("FullName") %>' />
                    </ItemTemplate>
                </asp:ListView></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Creation Date:"></asp:Label></td>
            <td><asp:Label ID="CreationDateLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label7" runat="server" Text="Approved by:"></asp:Label></td>
            <td>
                <asp:ListView ID="ListView1" runat="server" DataSourceID="ApprovedODS">
                    <ItemTemplate>
                            <asp:Label ID="FullNameLabel" runat="server" Text='<%# Eval("FullName") %>' />
                    </ItemTemplate>
                </asp:ListView>
                      
            </td>
        </tr>
       </table>


     <asp:GridView ID="PotentialHazardGV" runat="server" AutoGenerateColumns="False" DataSourceID="PotentialHazardODS">
        <Columns>
            <asp:TemplateField HeaderText="Potential Hazards" SortExpression="PotentialHazardID">
                    <ItemTemplate>
                        <asp:Label ID="PotentialHazardLabel" runat="server" Text='<%# Bind("PotentialHazardName") %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Exposure">
                    <ItemTemplate>
                        <asp:TextBox ID="ExposureTextBox" runat="server" Text='<%# Bind("ExposureLevel") %>'></asp:TextBox>
                    </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Probability">
                    <ItemTemplate>
                        <asp:TextBox ID="ProbabilityTextBox" runat="server" Text='<%# Bind("ProbabilityLevel") %>'></asp:TextBox>
                    </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Severity">
                    <ItemTemplate>
                        <asp:TextBox ID="SeverityTextBox" runat="server" Text='<%# Bind("SeverityLevel") %>'></asp:TextBox>
                    </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


    <asp:GridView ID="AdminHazardGV" runat="server" AutoGenerateColumns="False" DataSourceID="AdministrativeHazardODS">
         <Columns>
            <asp:TemplateField HeaderText="Administrative Hazards" SortExpression="AdministrativeHazardID">
                    <ItemTemplate>
                        <asp:Label ID="AdministrativeHazardLabel" runat="server" Text='<%# Bind("AdministrativeHazardName") %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="In Place">
                    <ItemTemplate>
                        <asp:RadioButton ID="RadioButton1" runat="server" />
                       
                    </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Required">
                   <ItemTemplate>
                        <asp:RadioButton ID="RadioButton1" runat="server" />
                    </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="N/A">
                    <ItemTemplate>
                        <asp:RadioButton ID="RadioButton1" runat="server" />
                    </ItemTemplate>
                  
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

     <tr>
            <td><asp:Label ID="Label6" runat="server" Text="Focus Area:"></asp:Label></td>
            <td> <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="FocusAreaODS" DataTextField="FocusAreaName" DataValueField="FocusAreaID"></asp:DropDownList></td>
        </tr>
          <tr>
            <td><asp:Label ID="Label8" runat="server" Text="Performing the Task:"></asp:Label></td>
            <td> <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="PerformerODS" DataTextField="PerformerName" DataValueField="PerformerID"></asp:DropDownList></td>
        </tr>

    <asp:ObjectDataSource ID="HATaskODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="HazardTask_List" TypeName="Engine.BLL.HazardTaskController"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="FocusAreaODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="FocusArea_List" TypeName="Engine.BLL.FocusAreaController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="DepartmentODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="DepartmentByAuthority" TypeName="Engine.BLL.HAController">
        <SelectParameters>
            <asp:ControlParameter ControlID="cookieLabel" Name="email" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>




    <asp:ObjectDataSource ID="PotentialHazardODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="PotentialHazard_List" TypeName="Engine.BLL.PotentialHazardController"></asp:ObjectDataSource>




    <asp:ObjectDataSource ID="AdministrativeHazardODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="List_ControlMeasures" TypeName="Engine.BLL.HAController"></asp:ObjectDataSource>




    <asp:ObjectDataSource ID="ApprovedODS" runat="server" SelectMethod="LoadAuthority" TypeName="Engine.BLL.HAController" OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:ControlParameter ControlID="cookieLabel" DefaultValue="" Name="email" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="PerformerODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Performer_List" TypeName="Engine.BLL.PerformerController"></asp:ObjectDataSource>


        <asp:Label ID="cookieLabel" runat="server" Text="" Visible="false"></asp:Label>

</asp:Content>

