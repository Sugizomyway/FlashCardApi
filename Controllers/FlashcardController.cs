using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlashCardApi.Data;
using FlashCardApi.Models;
using Microsoft.AspNetCore.Http;

namespace FlashCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashcardController : ControllerBase
    {
        // Fields
        private readonly IRepository _repo;
        private readonly ILogger<FlashcardController> _logger;
        // Constructor
        public FlashcardController(IRepository repo, ILogger<FlashcardController> logger)
        {
            this._repo = repo;
            this._logger = logger;
        }
        // Http Methods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlashCard>>> GetFlashCard(int id)
        {
            FlashCard fcard;
            try
            {
                fcard = await _repo.Get
            }
        }

    }
}