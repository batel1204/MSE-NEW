<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="ResetPassword" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<div>
    <fieldset style="width: 350px;">
        <legend>Change password example in asp.net</legend>
        <table>
            <tr>
                <td>User Name: * </td>
                <td>
                    <asp:textbox id="txtUserName" runat="server"></asp:textbox>
                    <br />
                    <asp:requiredfieldvalidator id="rfvuserName" runat="server"
                        errormessage="Please enter User Name" controltovalidate="txtUserName"
                        display="Dynamic" forecolor="Red" setfocusonerror="True"></asp:requiredfieldvalidator>
                </td>
            </tr>
            <tr>
                <td>Old Password: * </td>
                <td>
                    <asp:textbox id="txtOldPwd" runat="server" textmode="Password"></asp:textbox>
                    <br />
                    <asp:requiredfieldvalidator id="rfvOldPwd" runat="server"
                        errormessage="Please enter old password" controltovalidate="txtOldPwd"
                        display="Dynamic" forecolor="Red" setfocusonerror="True"></asp:requiredfieldvalidator>
                </td>
            </tr>
            <tr>
                <td>New Password: * </td>
                <td>
                    <asp:textbox id="txtNewPwd" runat="server" textmode="Password"></asp:textbox>
                    <br />
                    <asp:requiredfieldvalidator id="rfvNewPwd" runat="server"
                        errormessage="Please enter new password" controltovalidate="txtNewPwd"
                        display="Dynamic" forecolor="Red" setfocusonerror="True"></asp:requiredfieldvalidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password: * </td>
                <td>
                    <asp:textbox id="txtConfirmPwd" runat="server" textmode="Password"></asp:textbox>
                    <br />
                    <asp:requiredfieldvalidator id="rfvConfirmPwd" runat="server"
                        errormessage="Please re-enter password to confirm"
                        controltovalidate="txtConfirmPwd" display="Dynamic" forecolor="Red"
                        setfocusonerror="True"></asp:requiredfieldvalidator>
                    <asp:comparevalidator id="cmvConfirmPwd" runat="server"
                        controltocompare="txtNewPwd" controltovalidate="txtConfirmPwd"
                        display="Dynamic" errormessage="New and confirm password didn't match"
                        forecolor="Red" setfocusonerror="True"></asp:comparevalidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:button id="btnSubmit" runat="server" text="Change Password"
                        onclick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:label id="lblStatus" runat="server" text=""></asp:label>
                </td>
            </tr>
        </table>
    </fieldset>
</div>
</asp:Content>