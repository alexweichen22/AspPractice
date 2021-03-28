using FirstMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApplication.Controllers
{
    public class CalculatorController: Controller
    {
        //making an action
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator calculator)
        {
            double result = 0;
            switch (calculator.Operator)
            {
                case Operator.Sum:
                    result = calculator.Operand1 + calculator.Operand2;
                    break;
                case Operator.Substract:
                    result = calculator.Operand1 - calculator.Operand2;
                    break;
                case Operator.Multiply:
                    result = calculator.Operand1 * calculator.Operand2;
                    break;
                case Operator.Divide:
                    result = calculator.Operand1 / calculator.Operand2;
                    break;
            }
            calculator.Result = result;
            return View(calculator);
        }
    }
}
