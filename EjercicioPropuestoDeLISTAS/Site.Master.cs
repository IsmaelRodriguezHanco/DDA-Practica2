using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuestoDeLISTAS
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Electrodomesticos.Items.Add(new ListItem("Refrigedora", "1"));
                Electrodomesticos.Items.Add(new ListItem("Televisor", "2"));
                Electrodomesticos.Items.Add(new ListItem("Microondas", "3"));
                Electrodomesticos.Items.Add(new ListItem("Lavadora", "4"));

            }
            Grafico.Visible = false;
        }
        protected void Convertir_ServerClick(Object sender, EventArgs e)
        {
            
            decimal conversion = 0;
            ListItem elemento = Electrodomesticos.Items[Electrodomesticos.SelectedIndex];
            if (elemento.Value == "1")
            {
                
                Resultado.InnerText = " Codigo ---------- nombre ---------- descripcion----------  marca---------- precio";
                Resultado2.InnerText = "15687 ----------LG 679L----------No Frost LM85SXD Negro-----LG -------------8199";
            }
            if (elemento.Value == "2")
            {
                Resultado.InnerText = " Codigo ---------- nombre ---------- descripcion----------  marca---------- precio";
                Resultado2.InnerText = "19874 -------- SAMSUNG CRYSTAL -----UHD 70 Ultra HD ------SAMSUNG---------- 2799";
            }
            if (elemento.Value == "3")
            {
                Resultado.InnerText = " Codigo ---------- nombre ---------- descripcion----------  marca---------- precio ";
                Resultado2.InnerText = "98523 ---------- WINIA 28L------- WMN-28MD Gris Claro------WINIA-----------269";
            }
            if (elemento.Value == "4")
            {
                Resultado.InnerText = " Codigo ---------- nombre ---------- descripcion----------  marca---------- precio ";
                Resultado2.InnerText = "24653---------- Lavadora LG ------17Kg Negro Platino------- LG ----------- 2399";
            }
           

        }
        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
            Grafico.Alt = "Grafico Del Aparato";
            Grafico.Visible = true;
        }

    }
}