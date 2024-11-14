using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass11142024
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Only run this code if its not a post back
            {
                //This method runs when the page is loaded into
                // add a pizza company to the list box
                // How can we run this only one time?
                lbPizzaCompanies.Items.Add("LaRosa's");
                lbPizzaCompanies.Items.Add("Macs");
                lbPizzaCompanies.Items.Add("Jets Pizza");
                lbPizzaCompanies.Items.Add("Little Ceasers");

                cblIngredients.Items.Add("Mushrooms");
                cblIngredients.Items.Add("Bacon");
                cblIngredients.Items.Add("Onions");
                cblIngredients.Items.Add("Banana Peppers");
            }

        }

        protected void cmdSelectPizzaCompany_Click(object sender, EventArgs e)
        {
            //This code runs when the cmdSelectPizzaCompany button is pressed
            //we call this an "event handler"
            //write the currently selected pizza companies name on the label
            lblSelectedPizzaCompany.Text = lbPizzaCompanies.Text;
        }
    }
}