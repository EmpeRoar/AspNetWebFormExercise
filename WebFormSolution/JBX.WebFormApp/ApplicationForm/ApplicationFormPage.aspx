<%@ Page Title="Application Form" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ApplicationFormPage.aspx.cs" Inherits="JBX.WebFormApp.ApplicationForm.ApplicationFormPage" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div>
        <h3>Application Form</h3>
    </div>
    <div>
        <asp:Label ID="firstNameLabel" runat="server" Text="Firstname"></asp:Label>
        <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lastNameLabel" runat="server" Text="Lastname"></asp:Label>
        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="formSubmitButton" runat="server" Text="Submit" OnClick="formSubmitButton_Click" />
    </div>
    <div>
        <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
