using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class usuarioNegocio
    {

        public void insertarUsuarioNegocio(Entidad.Usuarios usuario)
        {

            Datos.usuarioDatos dc = null;

            try
            {

                dc = new Datos.usuarioDatos();

                dc.insertarUsuarioDatos(usuario);
                
            }
            catch (Exception err)
            {

                throw err;
            }


        } // fin del método insertarUsuarioNegocio

        public Entidad.Usuarios obtenerUsuarioNegocio(string nombreDeUsuario)
        {

            Datos.usuarioDatos dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                dc = new Datos.usuarioDatos();
                usuario = dc.obtenerUsuarioDatos(nombreDeUsuario);

                return usuario;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin del método obtenerUsuarioNegocio

        public void actualizarUsuarioNegocio(Entidad.Usuarios usuarioActualizar)
        {

            Datos.usuarioDatos dc = new Datos.usuarioDatos();

            try
            {

                dc.actualizarUsuarioDatos(usuarioActualizar);

            }
            catch (Exception err)
            {

                throw err;
            }

        }

        public void eliminarUsuarioNegocio(string usuarioEliminar)
        {

            Datos.usuarioDatos dc = null;

            try
            {

                dc = new Datos.usuarioDatos();
                              
                dc.eliminarUsuarioDatos(usuarioEliminar);

            }
            catch (Exception err)
            {

                throw err;
            }

        }

        public List<Entidad.Usuarios> obtenerListadoUsuarioNegocio()
        {

            Datos.usuarioDatos dc = null;
            List<Entidad.Usuarios> usuario = null;

            try
            {

                dc = new Datos.usuarioDatos();
                usuario = dc.obtenerListadoUsuarioDatos();

                return usuario;

            }
            catch (Exception err)
            {

                throw err;
            }



        } // fin del método obtenerListadoUsuarioNegocio

    } // fin de la clase usuarioNegocio
}
