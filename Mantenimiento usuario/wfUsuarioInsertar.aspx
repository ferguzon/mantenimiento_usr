<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioInsertar.aspx.cs" Inherits="Mantenimiento_usuario.wfUsuarioInsertar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 338px">Login (nombre de usuario)</td>
            <td>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ControlToValidate="txtLogin" ErrorMessage="Este es un campo obligatorio" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">Nombre de la persona</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="233px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">Contraseña</td>
            <td>
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px; height: 24px">Correo electrónico</td>
            <td style="height: 24px">
                <asp:TextBox ID="txtCorreoElectronico" runat="server" Width="231px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">Fecha de proceso</td>
            <td>
                <asp:Label ID="lblFechaProceso" runat="server" Font-Bold="True" ForeColor="#003399" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">&nbsp;</td>
            <td>
                <asp:CustomValidator ID="cvErrores" runat="server" ErrorMessage="CustomValidator" ForeColor="Red">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">&nbsp;</td>
            <td>
                <asp:ValidationSummary ID="vsResumenErrores" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td style="width: 338px">&nbsp;</td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Label ID="lblResultado" runat="server" Font-Bold="True" ForeColor="#003399"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
