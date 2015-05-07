using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.Device.Detection;

public partial class adaptive_rendering : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        // screenDimensions.Height and .Width will return 0 when a desktop browser is used
        DeviceScreenDimensions screenDimensions = Detector.GetScreenDimensions(Request.UserAgent);

        // Potentially bad check, but any width larger than 0 is a mobile device
        if (screenDimensions.Width > 0)
        {
            ResponsiveRadGrid.RenderMode = Telerik.Web.UI.RenderMode.Mobile;
        }
        else
        {
            ResponsiveRadGrid.RenderMode = Telerik.Web.UI.RenderMode.Lightweight;
        } */

        /*
        // Another approach to take. This gives us the following categories to act upon:
        // ExtraLarge - 1366+ CSS pixels
        // Large - 1025 - 1366 CSS pixels
        // Medium - 601 - 2014 CSS pixels
        // Small - Up to 600 CSS pixels
        DeviceScreenSize screenSize = Detector.GetScreenSize(Request.UserAgent);
        if (screenSize == DeviceScreenSize.Small)
        {
            ResponsiveRadGrid.RenderMode = Telerik.Web.UI.RenderMode.Mobile;
        }
        */
    }
    protected void ResponsiveRadGrid_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        List<SampleData> dataList = GenerateData();
        ResponsiveRadGrid.DataSource = dataList;
    }
 
    private List<SampleData> GenerateData()
    {
        List<SampleData> dataToCreate = new List<SampleData>();

        for(int i = 0; i < 20; i++)
        {
            dataToCreate.Add(new SampleData
            {
                ID = i,
                FirstName = string.Format("First Name [{0}]", i),
                LastName = string.Format("Last Name [{0}]", i)
            });
        }

        return dataToCreate;
    }

    public class SampleData
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAttending { get; set; }
    }
}