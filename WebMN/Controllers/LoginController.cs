﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMN.Models;

namespace WebMN.Controllers
{
    public class LoginController : Controller
    {

        Usuario usuarioModel = new Usuario();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult RegistrarCuenta()
        {
            return View();
        }

        public ActionResult RecuperarCuenta()
        {
            return View();
        }

    }
}