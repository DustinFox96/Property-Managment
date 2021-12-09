﻿using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]

    public class UnitController : ControllerBase
    {
        private readonly IUnitDao _unitDao;

        public UnitController(IUnitDao unitDao)
        {
            _unitDao = unitDao;
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult<List<Unit>> GetAllUnits()
        {
            return Ok(_unitDao.GetAllUnits());
        }
    }
}
