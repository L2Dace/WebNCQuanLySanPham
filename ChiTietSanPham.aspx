<%@ Page Title="" Language="C#" MasterPageFile="~/User_masterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="QuanLySanPhamTHTKW.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <image alt ="" src='image/<%# Eval("HINHANH") %>' width= "150px" height="150px" />
            <h1>Tên sản phẩm: <%# Eval("TENSANPHAM") %></h1>
            <%# Eval("MOTA") %>
        </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="drlSOLUONG" runat="server"></asp:DropDownList>
    <asp:Button ID="btn_GIOHANG" runat="server" Text="Giỏ hàng" OnClick="btn_GIOHANG_Click" />
</asp:Content>
