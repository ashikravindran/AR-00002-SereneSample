
namespace AR_00002_SereneSample.BasicSamples.Pages
{
    using System.Web.Mvc;

    [Authorize, RoutePrefix("BasicSamples"), Route("{action=index}")]
    public partial class BasicSamplesController : Controller
    {
    }
}
