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
    public partial class Admin : System.Web.UI.Page
    {
        SellerValidations sellerObj = new SellerValidations();
        AdminValidations adminObj = new AdminValidations();
        List<State> states = null;
        List<City> cities = null;
        static int stateId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            states = sellerObj.GetStates();
            cities = sellerObj.GetCities(stateId);
            if (!IsPostBack)
            {
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateName";
                ddlState.DataSource = states;
                // ddlState.SelectedIndex = 0;
                ddlState.DataBind();
                ddlCity.DataSource = cities;
                ddlCity.DataValueField = "CityName";
                ddlCity.DataBind();
                ddlSellerName.DataSource = adminObj.GetOwners();
                ddlSellerName.DataValueField = "UserName";
                ddlSellerName.DataBind();
            }
            Master.Login = false;
            Master.Signup = false;
            Master.Logout = true;
            Master.Profile = true;
            Master.lbl_Profile = Session["userName"].ToString();
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                State state = states[ddlState.SelectedIndex];
                stateId = state.StateId;
                cities = sellerObj.GetCities(stateId);
                ddlCity.DataSource = cities;
                ddlCity.SelectedIndex = 0;
                ddlCity.DataValueField = "CityName";
                ddlCity.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnSearchByRegion_Click(object sender, EventArgs e)
        {

        }

        protected void btnSearchBySeller_Click(object sender, EventArgs e)
        {

        }
    }
}