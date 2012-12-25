using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ITCR.UDSystem.Interfaz
{
	/// <summary>
	/// Descripci�n breve de frmError.
	/// </summary>
	public class frmError : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.TextBox txtDetallesError;
		protected System.Web.UI.WebControls.TextBox txtMensajeError;
		protected System.Web.UI.WebControls.TextBox txtGeneradoPor;
		protected System.Web.UI.WebControls.Label lblTitulo;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!Page.IsPostBack) 
			{
				if (Session["ObjetoError"] != null) 
				{
					try
					{
						//colocar la informacion del objeto error en los campos en pantalla
						Exception oError = (Exception) Session["ObjetoError"];
						txtMensajeError.Text = oError.Message;
						txtGeneradoPor.Text = oError.Source;
						txtDetallesError.Text = oError.ToString();
					}
					catch
					{
						//Con ITCRException no funcion�, hacerlo con Exception
						Exception oError = (Exception) Session["ObjetoError"];
						txtMensajeError.Text = oError.Message;
						txtGeneradoPor.Text = oError.Source;
						txtDetallesError.Text = oError.ToString();
					}
				}
			}
		}

		#region C�digo generado por el Dise�ador de Web Forms
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: llamada requerida por el Dise�ador de Web Forms ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
