﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;

namespace FinalProject.Controllers
{
    public class RegulatorController : Controller
    {
        private AssetsInContractContext _context;
        public static Regulator _regulator;
        public RegulatorController(AssetsInContractContext context)
        {
            _context = context;
        }

        public IActionResult RegulatorMainPage(Regulator regulator) //here the login succeeded , e initialized the key
        {
            _regulator = regulator;
            return View(_regulator);
        }
    }
}