<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioActualizar.aspx.cs" Inherits="Mantenimiento_usuario.wfUsuarioActualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:MultiView ID="mvVistasAgrupadas" runat="server">
        <asp:View ID="vwBuscarUsuario" runat="server">
            <table class="nav-justified">
                <tr>
                    <td style="width: 322px">Login del usuario a buscar</td>
                    <td>
                        <asp:TextBox ID="txtLogin" runat="server" Width="151px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ControlToValidate="txtLogin" ErrorMessage="Este campo es obligatorio" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 322px">&nbsp;</td>
                    <td>
                        <asp:CustomValidator ID="cvErrores" runat="server" ErrorMessage="CustomValidator" Font-Bold="True" ForeColor="Red">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 322px">&nbsp;</td>
                    <td>
                        <asp:ValidationSummary ID="vsResumenErrores" runat="server" Font-Bold="True" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 322px">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                </tr>
            </table>
        </asp:View>
         <asp:View ID="vwMostrarUsuario" runat="server">

              <table class="nav-justified">
        <tr>
            <td style="width: 338px">Login (nombre de usuario)</td>
            <td>
                <asp:TextBox ID="txtLoginAnterior" runat="server"></asp:TextBox>
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
                <asp:CustomValidator ID="cvErroresMostrarUsuario" runat="server" ErrorMessage="CustomValidator" ForeColor="Red">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">&nbsp;</td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td style="width: 338px">&nbsp;</td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                <asp:Label ID="lblResultado" runat="server" Font-Bold="True" ForeColor="#003399"></asp:Label>
            </td>
        </tr>
    </table>

        </asp:View>
         <asp:View ID="vwConfirmarEliminacion" runat="server">
            

             <table class="nav-justified">
                 <tr>
                     <td style="width: 246px">Login a eliminar</td>
                     <td>
                         <asp:Label ID="lblLoginEliminar" runat="server" Font-Bold="True" ForeColor="#003399" Text="Label"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 246px">&nbsp;</td>
                     <td>
                         <asp:CustomValidator ID="cvErrorEliminarUsuario" runat="server" Font-Bold="True" ForeColor="Red">*</asp:CustomValidator>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 246px">&nbsp;</td>
                     <td>
                         <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Por favor confirme que desea eliminar este usuario de la base de datos. Esta acción no puede deshacerse"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 246px">&nbsp;</td>
                     <td>
                         <asp:Button ID="btnConfirmarEliminacion" runat="server" BackColor="Red" Font-Bold="True" ForeColor="White" OnClick="btnConfirmarEliminacion_Click" Text="Eliminar usuario" />
                         &nbsp;<asp:Label ID="lblResultadoEliminacion" runat="server" Font-Bold="True" ForeColor="#003399"></asp:Label>
                     </td>
                 </tr>
             </table>
            

        </asp:View>



    </asp:MultiView>



</asp:Content>
