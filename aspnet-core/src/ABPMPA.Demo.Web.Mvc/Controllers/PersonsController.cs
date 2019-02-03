using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABPMPA.Demo.Controllers;
using ABPMPA.Demo.PhoneBooks;
using ABPMPA.Demo.PhoneBooks.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ABPMPA.Demo.Web.Mvc.Controllers
{
    public class PersonsController : DemoControllerBase
    {
        private readonly IPersonAppService _personAppService;


        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
        public async Task<IActionResult> Index(GetPersonInput input)
        {
            var dtos = await _personAppService.GetPagedPersonAsync(input);
            return View(dtos);
        }
    }
}