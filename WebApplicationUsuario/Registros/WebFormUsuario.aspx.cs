using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;
using DAL;

namespace WebApplicationUsuario.Registros
{
    public partial class WebFormUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        private void Limpiar()
        {
            tUsuarioId.Text = " ";
            tNombre.Text = " ";
            tNombre.Text = "";
            tEmail.Text = "";
            tPassword.Text = "";
            tConfirmarPassword.Text = "";
        }

        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioId = ToInt(tUsuarioId.Text);
            usuario.Nombres = tNombre.Text;
            usuario.NoTelefono = tEmail.Text;
            usuario.Email = tPassword.Text;
            usuario.Password = tConfirmarPassword.Text;
            
            return usuario;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            string s = tPassword.Text;
            string ss = tConfirmarPassword.Text;
            int comparacion = 0;
            comparacion = String.Compare(s, ss);
            if (comparacion != 0)
            {
                HayErrores = true;
            }

            return HayErrores;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            Usuario usuario = repositorio.Buscar(ToInt(tUsuarioId.Text));
            if (usuario != null)
            {
                tUsuarioID.Text = usuario.UsuarioId;
                tNombre.Text = usuario.Nombre;
                tEmail.Text = usuario.Email;
                tPassword.Text = usuario.Password;
                tConfirmarPassword.Text = usuario.ConfirmarPassword;
            }
            else
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BLL.Repositorio<Usuario> repositorio = new BLL.Repositorio<Usuario>();
            Usuario usuario = new Usuario();
            bool paso = false;

            if (HayErrores())
                Response.Write("<script>alert('Contraseñas no concuerdan');</script>");
            else
            {
                usuario = LlenaClase();

                if (usuario.UsuarioId == 0)
                {
                    paso = repositorio.Guardar(usuario);
                    Response.Write("<script>alert('Guardado');</script>");
                    Limpiar();
                }
                else
                {
                    int id = ToInt(usuarioIdTextBox.Text);
                    usuario = repositorio.Buscar(id);

                    if (usuario != null)
                    {
                        paso = repositorio.Modificar(LlenaClase());
                        Response.Write("<script>alert('Modificado');</script>");
                    }
                    else
                        Response.Write("<script>alert('Id no existe');</script>");
                }

                if (paso)
                {
                    Limpiar();
                }
                else
                    Response.Write("<script>alert('No se pudo guardar');</script>");
            }

        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            BLL.Repositorio<Usuario> repositorio = new BLL.Repositorio<Usuario>();
            int id = ToInt(usuarioIdTextBox.Text);

            var usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                if (repositorio.Eliminar(id))
                {
                    Response.Write("<script>alert('Eliminado');</script>");
                    Limpiar();
                }
                else
                    Response.Write("<script>alert('No se pudo eliminar');</script>");
            }
            else
                Response.Write("<script>alert('No existe');</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            BLL.Repositorio<Usuario> repositorio = new BLL.Repositorio<Usuario>();
            int id = ToInt(usuarioIdTextBox.Text);

            var usuario = repositorio.Buscar(id);

                if (usuario != null)
                {
                    if (repositorio.Eliminar(id))
                    {
                        Response.Write("<script>alert('Eliminado');</script>");
                        Limpiar();
                    }   
                    else
                        Response.Write("<script>alert('No se pudo eliminar');</script>");
                }
                else
                    Response.Write("<script>alert('No existe');</script>");
        }
    }
}