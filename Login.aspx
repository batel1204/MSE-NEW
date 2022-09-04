<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>



    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <form id="form1" runat="server">
    <div class="panel panel-inverse" style="width: 500px; margin: 100px auto 0px;">
            <div class="panel-heading">
                <h2 class="panel-title" style="color: white">מערכת לניהול פניות - מחלקת לוגיסטיקה אורט בראודה</h2>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label for="inputUser" class="col-md-3 control-label">שם משתמש</label>
                    <div class="col-md-5">
                        <asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" ID="inputUser" placeholder="שם משתמש" />
                    </div>
                    <div class="col-md-4 er-div">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="inputUser" ForeColor="Red"
                            ErrorMessage="שם משתמש הינו שדה חובה"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label for="inputPassword" class="col-md-3 control-label">סיסמא</label>
                    <div class="col-md-5">
                        <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="inputPassword" placeholder="סיסמא" />
                    </div>
                    <div class="col-md-4 er-div">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="inputPassword" ForeColor="Red"
                            ErrorMessage="סיסמא האינו שדה חובה"></asp:RequiredFieldValidator>
                    </div>

                    <div >
                        <a href="ResetPassword.aspx" style="color: grey; float: right;">שכחת סיסמא?</a>
                    </div>
                </div>
                <div class="form-group">
                    <label for="inputEmail" class="col-md-3 control-label">&nbsp;</label>
                    <div class="col-md-9">
                        <asp:Button runat="server" CssClass="btn btn-info" Text="כניסה" OnClick="Login_Click" />
                        <asp:Button runat="server" CausesValidation="False" Text="איתחול" CssClass="btn btn-default" OnClick="Reset_Click" />
                    </div>
                </div>
            </div>
        </div>


         <div style="width: 500px; margin: 10px auto; text-align: center; padding: 8px 0px">
            <asp:Panel runat="server" CssClass="alert alert-danger" ID="pnlMessage" Visible="false">
                זיהוי משתמש נכשל, נסה שנית..
            </asp:Panel>
        </div>
    </form>
        </asp:Content>

