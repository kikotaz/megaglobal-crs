using MegaGlobalCRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaGlobalCRS
{
    /*
     * @ClassName: index
     * @Description: This class will be the codebehind for the index.aspx page
     * @Developer: Karim Saleh
     */
    public partial class index : System.Web.UI.Page
    {
        //Getting single instance of the Data Access Layer
        private DataLayer dbCommander = DataLayer.GetInstance();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         * @Method: registerButton_CLick
         * @Params: object sender, EventArgs e
         * @Return: void
         * @Description: This method will be activated when the user clicks Register button,
         * it will collect his data, hash his password, and register the user in the database.
         */
        protected void registerButton_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            PasswordHasher hasher = new PasswordHasher();

            string hashedPassword = hasher.GetHashedPassword(passwordInput.Text, idInput.Text);

            //Constructing the insert query
            string query = "insert into tblUsers values('" + id + "','" +
                nameInput.Text + "','" + idInput.Text + "','" + hashedPassword + "')";

            string result = dbCommander.InsertRecord(query);

            if (result == "1")
            {
                //Closing database connection
                dbCommander.CloseConnection();

                registerStatus.Text = "User Created Successfully";
            }

        }
    }
}