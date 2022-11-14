<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageQuanLyDanhMuc.aspx.cs" Inherits="QuanLySanPhamTHTKW.ADMIN.pageQuanLyDanhMuc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 289px;
            width: 511px;
        }
        .auto-style2 {
            height: 55px;
        }
        .auto-style3 {
            height: 67px;
        }
        .auto-style4 {
            height: 54px;
        }
    </style>
</head>
<body style="height: 170px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <p>Mã danh mục</p>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMaDanhMuc" runat="server" Width="312px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <p>Tên danh mục</p>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtTenDanhMuc" runat="server" Width="312px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" ></td>
                <td class="auto-style4" >
                    <asp:Button ID="buttonsave" runat="server" Text="Lưu" OnClick="buttonsave_Click" Width="69px" BackColor="#66ff66" /> &nbsp;&nbsp;
                    <asp:Button ID="btnUpdate" runat="server" Text="Sửa" OnClick="btnUpdate_Click" Width="69px" BackColor="#ffff66" /> &nbsp;&nbsp;
                    <asp:Button ID="Delete_btn" runat="server" Text="Xoá" OnClick="Delete_btn_Click" Width="69px" BackColor="#ff6699" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grvDANHMUC" runat="server" Height="158px" Width="481px" AllowPaging="True" PageSize="3" OnPageIndexChanging="grvDANHMUC_PageIndexChanging">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
