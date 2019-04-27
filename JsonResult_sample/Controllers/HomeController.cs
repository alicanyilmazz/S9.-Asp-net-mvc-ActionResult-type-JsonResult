using JsonResult_sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//NOT PROJENDE AJAX VE JQUERY VEYA BOOTSRAPT VEYA JAVASCRİPT KULLANIYORSAN LİNKİNİ Layout ' a eklemeyi unutma.
// Sayfadaki hata AJAX,JQUERY,JAVASCRİPT hatası ise VisualStudio yakalayamayabilir o yüzden ctrl+shift+c geliştirici console unu takip et ordan kontrol et.
namespace JsonResult_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        [HttpGet]
        public JsonResult my_json_page()
        {
            product prdct = new product();
            prdct.product_ID = 5;
            prdct.product_name = "tomato";
            prdct.product_price = 12200;
            prdct.product_explanation = "this is a product explation.";

            /*
             *VERININ JSON FORMATINDA GONDERİLİSİ
            {
                product_ID:5,
                product_name:"tomato,
                product_price:12200,
                product_explanation:"this is a product explation.";

             }
            *VERININ XML FORMATINDA GONDERİLİSİ
            <product>
                    <product_ID></product_ID>
                    <product_name></product_name>
                    <product_price></product_price>
                    <product_explanation></product_explanation>
            </product>

             */
            // veri gönderilirken Json daha az kaplar daha az maliyetli çünkü XML de keyword'ler başta ve sonra iki kere tekrar edilir.



            return Json(prdct, JsonRequestBehavior.AllowGet); //JsonRequestBehavior.AllowGet yanlışlıkla GET Action'nın return 'üne Json yazıp onu biliçsizce döndürmeyin diye kontrol amaçlı bu metod ile izin veriyoruz.
        }

        [HttpPost]
        public JsonResult my_json_page(int? _value) //Httpost metodunu güvenlik açığı olmaması için yazmalısın açıklamayaı video sundan izle.
        {
            return Json(null);
        }


    }
}