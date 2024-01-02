using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Account_Management
{
    public partial class CustList : System.Web.UI.Page
    {
        Customer aCust = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                bind();
            }
        }

        protected void bind()
        {
            List<Customer> CustList = new List<Customer>();
            CustList = aCust.getCustomerList();
            gv_CustList.DataSource = CustList;
            gv_CustList.DataBind();
        }

        
    }
}