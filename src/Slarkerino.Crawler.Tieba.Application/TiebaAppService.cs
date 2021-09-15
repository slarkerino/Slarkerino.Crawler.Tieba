using System;
using System.Collections.Generic;
using System.Text;
using Slarkerino.Crawler.Tieba.Localization;
using Volo.Abp.Application.Services;

namespace Slarkerino.Crawler.Tieba
{
    /* Inherit your application services from this class.
     */
    public abstract class TiebaAppService : ApplicationService
    {
        protected TiebaAppService()
        {
            LocalizationResource = typeof(TiebaResource);
        }
    }
}
