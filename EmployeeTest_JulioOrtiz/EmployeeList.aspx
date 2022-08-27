<%@ Page Title="Employee List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EmployeeTest_JulioOrtiz.EmployeeList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<link href="~/Content/bootstrap.min.css" rel="stylesheet">

<div class="row">
        <!--TITLE-->
    <div style="height: 100%">
        <div class="container-fluid" style="padding-top: 2%">
            <asp:Label class="Title" ID="Label1" runat="server" ForeColor="Black" Text="EMPLOYEE VIEW"></asp:Label>
        </div>
        <div>
        </div>
        <!--FORMULARY-->
        <div class="Container-fluid">
            <table style="width:100%;">
                <tr>
                    <td style="width: 162px; height: 20px">
                        <asp:Label class="Title" ID="lblEmpID" runat="server" ForeColor="Black" Text="EmployeeID:"></asp:Label>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:Button ID="btnGet" runat="server" Text="Get Employee" OnClick="btnGet_Click"/>
                    </td>
                </tr>
                <tr>
                    <td style="width: 162px; height: 20px">
                        <asp:Label class="Title" ID="lblEmpFirstName" runat="server" ForeColor="Black" Text="Employee First Name:"></asp:Label>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:TextBox ID="txtEmplFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px; width: 162px;">
                        <asp:Label class="Title" ID="lblEmpLastName" runat="server" ForeColor="Black" Text="Employee Last Name:"></asp:Label>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:TextBox ID="txtEmplLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px; width: 162px;">
                        <asp:Label class="Title" ID="lblEmpPhone" runat="server" ForeColor="Black" Text="Employee Phone:"></asp:Label>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:TextBox ID="txtEmplPhone" runat="server" TextMode="Phone" ToolTip="(XXX) XXX-XXXX"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px; width: 162px;">
                        <asp:Label class="Title" ID="lblEmpZip" runat="server" ForeColor="Black" Text="Employee Zip:"></asp:Label>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:TextBox ID="txtEmpZip" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px; width: 162px;">
                        <asp:Label class="Title" ID="lblHireDate" runat="server" ForeColor="Black" Text="Hire Date:"></asp:Label>
                    </td>
                    <td style="width: 269px; height: 20px">
                        <asp:TextBox ID="txtHireDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="Container-fluid" style="padding-top:1%">

        </div>
        <div class="container text-center">
            <div class="row align-items-start">
                <div class="col-4">
                    <!--BUTTON TO CREATE-->
                    <asp:Button ID="btnCreateEmp" runat="server" Text="Create" OnClick="btnCreateEmp_Click"/>
                     <!--BUTTON TO UPDATE-->
                    <asp:Button ID="btnUpdateEmp" runat="server" Text="Update" OnClick="btnUpdateEmp_Click"/>
                    <!--BUTTON TO DELETE-->
                    <asp:Button ID="btnDeleteEmp" runat="server" Text="Delete" OnClick="btnDeleteEmp_Click"/>
                </div>
            </div>
        </div>
        <div class="container text-center">
        </div>
    </div>

    <div class="row">
        <div style="height: 100%">
            <div class="container-fluid" style="padding-top: 2%">
                <!--To add space betwen the title and the grid-->
            </div>
        </div>
        <div style="height: 100%; padding-left: 2%;">
            <asp:GridView ID="GridEmployees" runat="server">
            </asp:GridView>        
        </div>
        <div class="Container-fluid">
            <div class="container-fluid">
                <asp:Label class="Title" ID="lblMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
            </div>
        </div>
    </div>
</div>

    <script src="~/Scripts/jquery-1.9.1.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</asp:Content>