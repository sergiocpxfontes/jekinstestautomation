using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace xUnitText
{
   
    public class IndividuoControllerTest
    {
        [Fact]
        public void Teste_Escolha_De_View_Details()
        {
            var controller = new IndividuoController();
            var result = controller.Details(3) as ViewResult;
            Assert.Equal("Details", result.ViewName);
        }
        [Fact]
        public void Teste_Modelo()
        {
            var controller = new IndividuoController();
            var result = controller.Details(3) as ViewResult;
            var individuo = (Lib.Individuo)result.ViewData.Model;
            Assert.Equal("Sergio", individuo.Nome);
        }

        [Fact]
        public void Teste_ActionResult()
        {
            var controller = new IndividuoController();
            var result = (RedirectToActionResult)controller.Details(-1);
            Assert.Equal("Index", result.ActionName);
            
        }
    }
}
