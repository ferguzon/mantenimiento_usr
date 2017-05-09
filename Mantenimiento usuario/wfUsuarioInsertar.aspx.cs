using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenimiento_usuario
{
    public partial class wfUsuarioInsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                lblFechaProceso.Text = DateTime.Now.ToString();

            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.Usuarios usuarioNuevo = null;
            

            try
            {

                dc = new Negocio.usuarioNegocio();
                usuarioNuevo = new Entidad.Usuarios();

                usuarioNuevo.login = txtLogin.Text.Trim();
                usuarioNuevo.nombre = txtNombre.Text.ToUpper().Trim();
                usuarioNuevo.correo_electronico = txtCorreoElectronico.Text;
                usuarioNuevo.clave = txtClave.Text;
                usuarioNuevo.fecha_proceso = DateTime.Parse(lblFechaProceso.Text);

                dc.insertarUsuarioNegocio(usuarioNuevo);

                lblResultado.Text = "El usuario se guardó exitosamente";
                limpiarFormulario();

            }
            catch (Exception)
            {

                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Ocurrió un error al guardar la información.";

            } // fin del try

        } // fin de btnGuardar

        public void limpiarFormulario()
        {

            txtLogin.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtClave.Text = string.Empty;
            lblFechaProceso.Text = string.Empty;

        }

    } // fin de la clase
}