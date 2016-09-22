﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Source : System.Web.UI.Page
{
    public string Messu
    {
        get { return txtMessage.Text; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //täällä tehdään yleensä kaikki sivun alustukseen liittyvät
        //huom mutta vain yhden kerran tässä tapauksessa
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Ping!");
            ddlMessages.Items.Add("Hello, handshake?");
            ddlMessages.Items.Add("Goodbye");
        }
    }

    protected void btnQueryString_Click(object sender, EventArgs e)
    {
        //ohjataan pyyntö uudelle sivulle ja välitetään teksti kutsun mukana
        Response.Redirect("Tapa1.aspx?Data=" + txtMessage.Text);
    }

    protected void btnHttpPost_Click(object sender, EventArgs e)
    {
        //ohjataan pyyntö uudelle sivulle ja välitetään teksti kutsun mukana
        Response.Redirect("Tapa2.aspx?Data=" + txtMessage.Text);
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        //kirjoitettaan sessioniin
        Session["viesti"] = txtMessage.Text;
        Response.Redirect("Tapa3.aspx");
    }
    protected void btnCookie_Click(object sender, EventArgs e)
    {
        //Luodaan keksi ja kirjoitetaan siihen
        HttpCookie keksi = new HttpCookie("viesti", txtMessage.Text);
        Response.Cookies.Add(keksi);
        Response.Redirect("Tapa4.aspx");
    }

    protected void btnProperty_Click(object sender, EventArgs e)
    {
        Server.Transfer("Tapa5.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = ddlMessages.SelectedItem.ToString();
    }
}