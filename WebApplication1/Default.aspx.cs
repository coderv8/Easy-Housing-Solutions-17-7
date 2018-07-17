using EasyHousingSolutions_BLL;
using EasyHousingSolutions_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        SellerValidations sellerObj = new SellerValidations();
        List<State> states = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userId"] = null;
            Session["userName"] = null;
            states = sellerObj.GetStates();
            if (!IsPostBack)
            {
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateName";
                ddlState.DataSource = states;
                // ddlState.SelectedIndex = 0;
                ddlState.DataBind();
                ddlCity.DataSource = sellerObj.GetCities(1);
                ddlCity.DataValueField = "CityName";
                ddlCity.DataBind();
            }
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                State state = states[ddlState.SelectedIndex];
                ddlCity.DataSource = sellerObj.GetCities(state.StateId);
                ddlCity.SelectedIndex = 0;
                ddlCity.DataValueField = "CityName";
                ddlCity.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {

        }
    }
}