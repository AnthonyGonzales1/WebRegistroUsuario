using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;
using DAL;

namespace WebApplicationUsuario.Consultas
{
    public partial class WebConsultUsuario : System.Web.UI.Page
    {
        Expression<Func<Usuario, bool>> filtro = p => true;
        Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
        public static List<Usuario> listUsuarios { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            listUsuarios = repositorio.GetList(x => true);
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    id = ToInt(tCriterio.Text);
                    filtro = p => p.UsuarioId == id;
                    break;

                case 2:
                    filtro = p => p.Nombres.Contains(tCriterio.Text);
                    break;

                case 3:
                    filtro = p => p.Email.Contains(tCriterio.Text);
                    break;
            }
            listUsuarios = repositorio.GetList(filtro);
            UsuarioGridView.DataSource = listUsuarios;
            UsuarioGridView.DataBind();
        }

        public static List<Usuario> RetornarUsuarios()
        {
            return Usuarios;
        }
    }
}