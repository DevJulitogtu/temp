using System;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Apps.Insurance.Web.Controllers
{
    public class BaseController : Controller
    {
        public string DisplayName { get; set; }
    }
}