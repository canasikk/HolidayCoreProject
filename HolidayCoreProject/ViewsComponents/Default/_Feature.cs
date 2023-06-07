using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayCoreProject.ViewsComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeaturesManager featuresManager = new FeaturesManager(new EfFeaturesDal());

        public IViewComponentResult Invoke()
        {
            // var values = featuresManager.TGetList();
            //ViewBag.image1 = featuresManager.TGetById();
           return View();
        }
    }
}
