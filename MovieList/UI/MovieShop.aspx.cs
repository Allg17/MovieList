using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieList.UI
{
    public partial class MovieShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BLL.RepositorioBase<Movie> repositorioBase = new BLL.RepositorioBase<Movie>();
                MovieCar movieCar = new MovieCar();
                ViewState["Movie"] = repositorioBase.GetList(x => true);
                ViewState["MovieCar"] = movieCar;
                DataBinds();
            }
        }

        private void DataBinds()
        {
            DatosDataList.DataSource = (List<Movie>)ViewState["Movie"];
            DatosDataList.DataBind();
        }

        protected void DatosDataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("Agregar"))
            {
                TextBox cantidad = (TextBox)(e.Item.FindControl("CantidadTextBox"));
                if (Convert.ToInt32(cantidad.Text) > 0)
                {


                    var Articulo = ((List<Movie>)ViewState["Movie"]).ElementAt(e.Item.ItemIndex);


                    //Agregando al Detalle los items
                    ((MovieCar)ViewState["MovieCar"]).Detalle.Add(new MovieCarDetalle(0, 0, Articulo.Descripcion, Convert.ToInt32(cantidad.Text), Articulo.Precio, BLL.HerramientasBLL.CalcularImporte(Convert.ToInt32(cantidad.Text), Articulo.Precio)));

                    //Agregando cantidad de peliculas a la entidad
                    ((MovieCar)ViewState["MovieCar"]).CantidadMovie = ((MovieCar)ViewState["MovieCar"]).Detalle.Count;

                    //Visualizando cantidad de items agregados
                    ItemLinkButton.Text = "Items " + ((MovieCar)ViewState["MovieCar"]).Detalle.Count.ToString();


                    //Session
                    Session["MovieCar"] = null;
                    Session["MovieCar"] = (MovieCar)ViewState["MovieCar"];
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Agregado');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No puede agregar esa Cantidad!!');", addScriptTags: true);
                }
            }
        }

        protected void ItemLinkButton_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('cMoviesCar.aspx','_blanck');</script");
            Server.Transfer("MovieShop.aspx");
        }
    }
}