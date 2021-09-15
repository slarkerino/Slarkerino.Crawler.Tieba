using Slarkerino.Crawler.Tieba.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Slarkerino.Crawler.Tieba.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TiebaController : AbpController
    {
        protected TiebaController()
        {
            LocalizationResource = typeof(TiebaResource);
        }
    }
}