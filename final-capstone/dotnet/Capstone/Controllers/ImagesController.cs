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
    public class ImagesController : ControllerBase
    {
        private readonly IImagesDao _imagesDao;

        public ImagesController(IImagesDao imagesDao)
        {
            _imagesDao = imagesDao;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<List<Images>> GetAllImgages()
        {
            return Ok(_imagesDao.GetAllImages());
        }
    }
}
