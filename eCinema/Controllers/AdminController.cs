﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Data;
using FileUploadControl;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private UploadInterface _upload;
        public AdminController(ApplicationDbContext context, UploadInterface upload)
        {
            _upload = upload;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}