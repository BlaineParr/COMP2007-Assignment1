﻿<%@ Page Title="Game Calculator" Language="C#" MasterPageFile="~/MasterPages/Frontend.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="COMP2007_Assignment1._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--Title: COMP2007 Assignment 1: Game Calculator
     *  Author: Blaine Parr
     *  Date: June 19, 2015
     *  Purpose: This application takes the user's input from a form and calculates statistics about four games that were played.
     *  The application then outputs the information for the user to see.-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="jumbotron">
            <div class="container">
                <h1>Game Calculator</h1>
                <p>Summarize stats about your games!</p>
            </div>
            <!--container-->
        </div>
        <!--jumbotron-->
        <div class="row">
            <div class="col-md-3">
                <h2>Game 1</h2>
                <div class="form-group">
                    <asp:Label ID="ResultLabel1" CssClass="form-label" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList1" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel1" CssClass="form-label" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox1" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel1" CssClass="form-label" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox1" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel1" CssClass="form-label" runat="server" Text="Number of Spectators:"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox1" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
            <div class="col-md-3">
                <h2>Game 2</h2>
                <div class="form-group">
                    <asp:Label ID="ResultLabel2" CssClass="form-label" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList2" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel2" CssClass="form-label" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox2" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel2" CssClass="form-label" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox2" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel2" CssClass="form-label" runat="server" Text="Number of Spectators:"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox2" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
            <div class="col-md-3">
                <h2>Game 3</h2>
                <div class="form-group">
                    <asp:Label ID="ResultLabel3" CssClass="form-label" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList3" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel3" CssClass="form-label" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox3" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel3" CssClass="form-label" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox3" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel3" CssClass="form-label" runat="server" Text="Number of Spectators:"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox3" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
            <div class="col-md-3">
                <h2>Game 4</h2>
                <div class="form-group">
                    <asp:Label ID="ResultLabel4" CssClass="form-label" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList4" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel4" CssClass="form-label" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox4" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel4" CssClass="form-label" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox4" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel4" CssClass="form-label" runat="server" Text="Number of Spectators:"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox4" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
        </div>
        <!--row-->
        <div id="button">
            <asp:Button ID="SummaryButton" CssClass="btn-success" runat="server" Text="Summary" OnClick="SummaryButton_Click" />
            <asp:Button ID="ClearButton" CssClass="btn-warning" runat="server" Text="Clear Form" OnClick="ClearButton_Click" />
        </div>
        <!--button-->
        <div runat="server" id="output">
            <asp:Label ID="GamesWonOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="GamesLostOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="WinPercentageOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="TotalPointsScoredOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="TotalPointsAllowedOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="PointDifferentialOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="TotalSpectatorsOutputLabel" CssClass="form-label" runat="server"></asp:Label><br />
            <asp:Label ID="AverageSpectatorsLabel" CssClass="form-label" runat="server"></asp:Label><br />
        </div>
    </div>
    <!--container-fluid-->
</asp:Content>
