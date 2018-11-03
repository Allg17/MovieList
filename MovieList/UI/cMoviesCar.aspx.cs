using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieList.UI
{
    public partial class cMoviesCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["Shop"] = (MovieCar)Session["MovieCar"];
                DataListBind();
            }
        }

        private void DataListBind()
        {
            decimal Total = 0;
            foreach (var item in ((MovieCar)ViewState["Shop"]).Detalle)
            {
                Total += item.Importe;
            }
            CantidadTextBox.Text = Total.ToString();
            ((MovieCar)ViewState["Shop"]).Total = Convert.ToDecimal(CantidadTextBox.Text);
            DatosGridView.DataSource = ((MovieCar)ViewState["Shop"]).Detalle;
            DatosGridView.DataBind();
        }

        protected void DatosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DatosGridView.DataSource = ((MovieCar)ViewState["Shop"]).Detalle;
            DatosGridView.PageIndex = e.NewPageIndex;
            DatosGridView.DataBind();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<MovieCar> repositorioBase = new BLL.RepositorioBase<MovieCar>();
            if(repositorioBase.Guardar(((MovieCar)ViewState["Shop"])))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado');", addScriptTags: true);
                GuardarButton.Enabled = false;
                ViewState["Shop"] = repositorioBase.GetList(x => true).Last();
                DataListBind();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No puedo Guardar');", addScriptTags: true);
            }
        }
    }
}