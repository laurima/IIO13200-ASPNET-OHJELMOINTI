using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class vk01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        //lasketaan ikkunan tarjoushinta
        try
        {
            //Käyttäjän syötteet on AINA syytä tarkistaa
            if (txtKorkeus.Text.Length * txtLeveys.Text.Length * txtKarminLeveys.Text.Length > 0)
            {
                double leveys = Convert.ToDouble(txtLeveys.Text);
                double korkeus = Convert.ToDouble(txtKorkeus.Text);
                double karmi = Convert.ToDouble(txtKarminLeveys.Text);
                double pintaala = (korkeus - ((2 * karmi)) / 1000) * ((leveys - (2 * karmi)) / 1000); // €/m2
                double piiri = 2 * ((leveys / 1000) + (korkeus / 1000)); // €/jm
                double aluhinta = Convert.ToDouble(ConfigurationManager.AppSettings["alumiinihinta"]);
                double lasihinta = 45;
                double tyomenekki = 150; // €/ikkuna
                double kate = 0.3; // kate 30%
                //hinnan laskenta
                double hinta = (1 + kate) * ((pintaala * lasihinta) + (piiri * aluhinta) + tyomenekki);
                //Tulos UI:hin
                lblHinta.Text = hinta.ToString("C2", CultureInfo.CreateSpecificCulture("fi-Fi"));
                lblKarminPiiri.Text = piiri.ToString();
                lblPintaala.Text = pintaala.ToString();
                lblMessages.Text = "";

            }
            else
            {
                lblMessages.Text = "Tarkista syötteet. Jokin puuttuu...";
            }
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}