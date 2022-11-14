<%@ Page Title="" Language="C#" MasterPageFile="~/User_masterPage.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="QuanLySanPhamTHTKW.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvCART" runat="server" Width="747px" AutoGenerateColumns="False" Height="268px" ShowFooter="True">
        <Columns>
            <asp:BoundField DataField="MASANPHAM" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành tiền" />
            <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="IMAGE/{0}" HeaderText="Ảnh ">
            </asp:ImageField>
            <asp:TemplateField HeaderText="Trả hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbREMOVEITEM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnDELETE" runat="server" OnClick="btnDELETE_Click" Text="Trả Hàng" />
</asp:Content>
