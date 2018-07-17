<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SellerHome.aspx.cs" Inherits="WebApplication1.SellerHome" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2" style="text-align: center"><Legend>Seller</Legend>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; vertical-align: top;">
                <div class="form-group">
                    <asp:Label ID="lblSort" runat="server" Text="Sort Property By " Width="70%" Height="40px"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnVerifiedProp" Text="Verified" runat="server" ForeColor="White" BackColor="Gray" class="btn btn-default" Width="50%" Height="40px" OnClick="btnVerifiedProp_Click" />
                </div>
                <div class="form-group">
                     <asp:Button ID="btnDeactivatedProp" Text="Deactivated" runat="server" ForeColor="White" BackColor="Gray" class="btn btn-default" Width="50%" Height="40px" OnClick="btnDeactivatedProp_Click"/>
                </div>

                <div class="form-group">
                     <asp:Button ID="btnAllProp" runat="server" Text="Show All" ForeColor="White" BackColor="Gray"   class="btn btn-default" Width="50%" Height="40px" OnClick="btnAllProp_Click" />
                </div>

                <div class="form-group">
                    <asp:Button ID="btnAddProp" runat="server" Text="Add Property" BackColor="Green" ForeColor="White"  class="btn btn-default" Width="50%" Height="40px" OnClick="btnAddProp_Click" />
                </div>
            </td>

            <td style="width: 80%; vertical-align: top">
                <%--<asp:ContentPlaceHolder ID="cphLnDBody" runat="server"></asp:ContentPlaceHolder>--%>

            </td>
        </tr>
    </table>
</asp:Content>
