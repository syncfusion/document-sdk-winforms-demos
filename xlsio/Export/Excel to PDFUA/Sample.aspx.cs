using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Excel to PDF/UA Sample";
            Image1.ImageUrl = "~/Product Showcase/Excel to PDF/Images/ExcelToPDFUA.png"; 			
        }
    }
}
