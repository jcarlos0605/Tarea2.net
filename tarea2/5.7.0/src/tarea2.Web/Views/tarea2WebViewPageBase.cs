using Abp.Web.Mvc.Views;

namespace tarea2.Web.Views
{
    public abstract class tarea2WebViewPageBase : tarea2WebViewPageBase<dynamic>
    {

    }

    public abstract class tarea2WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected tarea2WebViewPageBase()
        {
            LocalizationSourceName = tarea2Consts.LocalizationSourceName;
        }
    }
}