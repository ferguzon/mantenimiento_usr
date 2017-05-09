using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenimiento_usuario
{
    public partial class wfUsuarioListadoReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Negocio.usuarioNegocio dc = new Negocio.usuarioNegocio();

                rptListadoUsuarios.LocalReport.ReportEmbeddedResource = "Presentacion.rptListadoUsuarios.rdlc";
                rptListadoUsuarios.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("conexion", dc.obtenerListadoUsuarioNegocio()));

                rptListadoUsuarios.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("login", "login"));
                rptListadoUsuarios.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("nombre", "nombre"));
                rptListadoUsuarios.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("correo_electronico", "correo_electronico"));
                rptListadoUsuarios.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("fecha_proceso", "fecha_proceso"));

                rptListadoUsuarios.LocalReport.Refresh();

            } // fin del if IsPostBack

        }
    }
}