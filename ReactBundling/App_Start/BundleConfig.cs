using System.Web.Optimization;
using System.Web.Optimization.React;

namespace ReactBundling
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new JsxBundle("~/bundles/react-halodunia")
                .Include("~/Scripts/react/react-{version}.js")
                .Include("~/Scripts/jsx/HaloDunia.jsx"));
        }
    }
}