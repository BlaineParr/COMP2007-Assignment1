<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Frontend.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="COMP2007_Assignment1._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Welcome Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <div class="form-group">
                    <asp:Label ID="ResultLabel1" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList1" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel1" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox1" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel1" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox1" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel1" runat="server" Text="Number of Spectators"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox1" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
            <div class="col-md-3">
                <div class="form-group">
                    <asp:Label ID="ResultLabel2" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList2" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel2" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox2" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel2" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox2" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel2" runat="server" Text="Number of Spectators"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox2" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
            <div class="col-md-3">
                <div class="form-group">
                    <asp:Label ID="ResultLabel3" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList3" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel3" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox3" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel3" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox3" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel3" runat="server" Text="Number of Spectators"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox3" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
            <div class="col-md-3">
                <div class="form-group">
                    <asp:Label ID="ResultLabel4" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="ResultRadioButtonList4" runat="server">
                        <asp:ListItem Value="Win"></asp:ListItem>
                        <asp:ListItem Value="Lose"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsScoredLabel4" runat="server" Text="Points Scored:"></asp:Label>
                    <asp:TextBox ID="PointsScoredTextBox4" CssClass="form-control" runat="server" placeholder="Enter Points Scored"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="PointsAllowedLabel4" runat="server" Text="Points Allowed:"></asp:Label>
                    <asp:TextBox ID="PointsAllowedTextBox4" CssClass="form-control" runat="server" placeholder="Enter Points Allowed"></asp:TextBox>
                </div>
                <!--form-group-->
                <div class="form-group">
                    <asp:Label ID="SpectatorsLabel4" runat="server" Text="Number of Spectators"></asp:Label>
                    <asp:TextBox ID="SpectatorsTextBox4" CssClass="form-control" runat="server" placeholder="Enter Number of Spectators"></asp:TextBox>
                </div>
                <!--form-group-->
            </div>
            <!--col-md-3-->
        </div>
        <!--row-->
    </div>
    <!--container-fluid-->
</asp:Content>
