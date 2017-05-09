using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenimiento_usuario
{
    public partial class wfUsuarioActualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                mvVistasAgrupadas.SetActiveView(vwBuscarUsuario);

            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                dc = new Negocio.usuarioNegocio();
                usuario = dc.obtenerUsuarioNegocio(txtLogin.Text);

                

                txtLoginAnterior.Text = usuario.login;
                txtNombre.Text = usuario.nombre;
                txtCorreoElectronico.Text = usuario.correo_electronico;
                txtClave.Text = usuario.clave;
                lblFechaProceso.Text = usuario.fecha_proceso.ToString();

                mvVistasAgrupadas.SetActiveView(vwMostrarUsuario);

                Session.Add("s_Usuario", txtLogin.Text);

            }
            catch (Exception)
            {

                mvVistasAgrupadas.SetActiveView(vwBuscarUsuario);
                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Ocurrió un error al recuperar la información. Por favor verifique los datos.";
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = new Negocio.usuarioNegocio();
            Entidad.Usuarios usuario = new Entidad.Usuarios();

            try
            {

                usuario.login = txtLoginAnterior.Text;
                usuario.nombre = txtNombre.Text;
                usuario.correo_electronico = txtCorreoElectronico.Text;
                usuario.clave = txtClave.Text;

                dc.actualizarUsuarioNegocio(usuario);

                limpiarFormulario();

                lblResultado.Text = "La información se actualizó correctamente.";

            }
            catch (Exception)
            {

                cvErroresMostrarUsuario.IsValid = false;
                cvErroresMostrarUsuario.ErrorMessage = "Ocurrió un error al actualizar. Por favor verifique.";
            }

        }

        public void limpiarFormulario()
        {

            txtLogin.Text = string.Empty;
            txtLoginAnterior.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtClave.Text = string.Empty;
            lblFechaProceso.Text = string.Empty;
            

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

                mvVistasAgrupadas.SetActiveView(vwConfirmarEliminacion);
                lblLoginEliminar.Text = Session["s_Usuario"].ToString();
            

        }

        protected void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = new Negocio.usuarioNegocio();

            try
            {

                dc.eliminarUsuarioNegocio(Session["s_Usuario"].ToString());

                limpiarFormulario();
                lblResultadoEliminacion.Text = "Se eliminó el usuario de la base de datos.";

                Session.Remove("s_Usuario");
                

            }
            catch (Exception)
            {
                cvErrorEliminarUsuario.IsValid = false;
                cvErrorEliminarUsuario.ErrorMessage = "Ocurrió un error al eliminar el usuario.";
                
            }

        }
    }
}