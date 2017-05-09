using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class usuarioDatos
    {

        public void insertarUsuarioDatos(Entidad.Usuarios usuario)
        {

            Entidad.CursoNetEntities dc = null;
           
            try
            {

                // guardamos el usuario que recibimos de la capa de negocio

                dc = new Entidad.CursoNetEntities();
                dc.Usuarios.Add(usuario);

                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;

            } // fin del try

        } // fin del método insertarUsuarioDatos

        public Entidad.Usuarios obtenerUsuarioDatos(string login)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                usuario = dc.Usuarios.Where(u => u.login == login).FirstOrDefault();

                return usuario;

            }
            catch (Exception err)
            {

                throw err;
            }


        } // fin del método obtenerUsuarioDatos

        public void actualizarUsuarioDatos(Entidad.Usuarios usuario)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuarioActualizar = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
             
                usuarioActualizar = dc.Usuarios.Where(u => u.login == usuario.login).FirstOrDefault();

                usuarioActualizar.login = usuario.login;
                usuarioActualizar.nombre = usuario.nombre;
                usuarioActualizar.clave = usuario.clave;
                usuarioActualizar.correo_electronico = usuario.correo_electronico;

                dc.SaveChanges();


            }
            catch (Exception err)
            {

                throw err;
            }

        }

        public void eliminarUsuarioDatos(string acceso)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                usuario = dc.Usuarios.Where(pi => pi.login == acceso).FirstOrDefault();

                dc.Usuarios.Remove(usuario);
                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin del método eliminarUsuarioDatos

        public List<Entidad.Usuarios> obtenerListadoUsuarioDatos()
        {

            Entidad.CursoNetEntities dc = null;
            List<Entidad.Usuarios> usuario = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                usuario = dc.Usuarios.ToList();

                return usuario;


            }
            catch (Exception err)
            {

                throw err;
            }


        } // fin del método obtenerListadoUsuarioDatos

    } // fin de clase usuarioDatos
}
