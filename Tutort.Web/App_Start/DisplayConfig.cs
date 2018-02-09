using System.Collections.Generic;
using System.Web.WebPages;

namespace Tutort.Web.App_Start
{
    public class DisplayConfig
    {
        public static void RegisterDisplayModes(
          IList<IDisplayMode> displayModes)
        {
            //var modeSmartphone = new DefaultDisplayMode("Mobile")
            //{
            //    ContextCondition = (c => c.Request.IsSmartphone())
            //};

            //var modeTablet = new DefaultDisplayMode("Tablet")
            //{
            //    ContextCondition = (c => c.Request.IsTablet())
            //};

            //var modeDesktop = new DefaultDisplayMode("")
            //{
            //    ContextCondition = (c => c.Request.IsDesktop())
            //};

            //displayModes.Clear();
            //displayModes.Add(modeSmartphone);
            //displayModes.Add(modeTablet);
            //displayModes.Add(modeDesktop);
        }
    }
}