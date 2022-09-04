<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        var scope;

        $(function () {
            scope = angular.element($("body")).scope();
            scope.UserId = "<%=Session["uid"]%>";
            scope.UserLevel = "<%=Session["level"]%>";
            scope.UserName = "<%=Session["user"]%>";

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#" data-ng-click="setPage('MyTicket')"><i class="icon ion-ios-gear"></i>	&nbsp MSE system</a>
            </div>

            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                <ul class="nav navbar-nav">
                    <%--<li data-ng-repeat="m in appMenu[currentUser.Permission].Menu" >
                        <a href="#" data-ng-show="m.type=='def'" data-ng-bind="m.Title" data-ng-click="setPage()"></a>
                    </li>--%>
                    <li><a href="#" data-ng-click="setPage('Reports')" data-ng-show="currentUser.Permission!='1' || currentUser.Permission!='2'">דוחות</a></li>
                    <li><a href="#" data-ng-click="currentPage='ManageUsers'" data-ng-show="currentUser.Permission=='0'">ניהול משתמשים</a></li>
                </ul>
                
                <ul class="nav navbar-nav navbar-left" >
                    <li><a href="Default.aspx?log=out"><b>יציאה</b></a></li>
                </ul>

                <ul class="nav navbar-nav navbar-left">
                    <li style="top: 16px; color: white;">שלום <b><%=Session["user"] %></b>!</li>
                </ul>
            </div>

        </div>
    </nav>


    <div style="overflow: auto; max-height: 640px;"  >
       
        <div class="btn-group pull-right" style="margin: 20px 0px 5px 0px" >
            <a href="#" id="btn-new" class="btn btn-primary" data-ng-click="setPage('createTicket')"><i class="icon ion-ios-plus-outline"></i>	&nbspפניה חדשה </a>
            <a href="#" id="btn-my" class="btn btn-default" data-ng-click="setPage('MyTicket')"><span></span>&nbspהפניות שלי</a>
            <a href="#" id="btn-todo" class="btn btn-default" data-ng-show="currentUser.Permission!=1" data-ng-click="setPage('TicketsToDo')"><span></span>&nbspפניות לטיפולי</a>
            <a href="#" id="btn-search" class="btn btn-default" data-ng-show="currentUser.Permission!=1" data-ng-click="setPage('Search')"><i class="icon ion-ios-search"></i>	&nbspחיפוש</a>
        </div>
        
        <div class="main-content">
            <div data-ng-if="currentPage=='createTicket'" data-ng-include="'Pages/CreateTicket.htm'"></div>
            <div data-ng-if="currentPage=='MyTicket'" data-ng-include="'Pages/MyTicket.html'"></div>
            <div data-ng-if="currentPage=='TicketsToDo'" data-ng-include="'Pages/TicketsToDo.htm'"></div>
            <div data-ng-if="currentPage=='Search'" data-ng-include="'Pages/Search.htm'"></div>
            <div data-ng-if="currentPage=='Reports'" data-ng-include="'Pages/Reports.htm'"></div>

            

        </div>
    </div>
</asp:Content>
