using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDeveloper.Reports
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                var name = Page.RouteData.Values["name"].ToString();
                var reportParameter = new ReportParameter("reportName",name);
                //var reportParameter = new ReportParameter("reportName", "test");

                rptView.ProcessingMode = ProcessingMode.Local;
                rptView.LocalReport.ReportPath = Server.MapPath("~/Reports/StateProvinceCountryRegion.rdlc");
                var dataSet = GetData();
                var reportDataSource = new ReportDataSource("AdventureWorksDataSet", dataSet.Tables[0]);
                rptView.LocalReport.DataSources.Clear();
                rptView.LocalReport.SetParameters(reportParameter);
                rptView.LocalReport.DataSources.Add(reportDataSource);
                //rptView.DataBind();
            }

        }

        private AdventureWorks2014DataSet GetData() {
            var query = "SELECT * FROM Person.vStateProvinceCountryRegion";
            var connectionString = ConfigurationManager.ConnectionStrings["WebDeveloperConnectionString"].ConnectionString;
            var command = new SqlCommand(query);
            using (var connection = new SqlConnection(connectionString)) {
                command.Connection = connection;
                using (var adapter = new SqlDataAdapter()){
                    adapter.SelectCommand = command;
                    using (var dataset = new AdventureWorks2014DataSet()) {
                        adapter.Fill(dataset, "AdventureWorksDataSet");
                        return dataset;
                    }
                }
            }
        }
    }
}