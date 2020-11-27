using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePetStoreInfoAPI.Models;
using OnlinePetStoreInfoAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlinePetStoreInfoAPI.Controllers
{
    [Route("api/[controller]")]
    public class StoreController : Controller
    {
        private PetStoreInterface _petStoreInterface;
        private readonly IMapper _mapper;


        public StoreController(PetStoreInterface petStoreInterface, IMapper mapper)
        {
            _petStoreInterface = petStoreInterface;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<PetStoreModel>> GetPetStore()
        {
            var petStoreEntities = await _petStoreInterface.GetPetStore();
            var results = _mapper.Map<IEnumerable<PetStoreModel>>(petStoreEntities);
            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PetStoreModel>> GetStoreById(int id)
        {
            var petStore = await _petStoreInterface.GetStoreById(id);
            if (petStore == null)
            {
                return NotFound();
            }
            var petStoreResults = _mapper.Map<PetStoreModel>(petStore);
            return Ok(petStoreResults);
        }

        [HttpPost]
        public async Task<ActionResult<PetStoreModel>> AddPetStore([FromBody] PetStoreModel petStore)
        {
            if(petStore == null)
            {
                return BadRequest();
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(await _petStoreInterface.StoreExist(petStore.StoreId))
            {
                return NotFound();
            }
            var lastStore = _mapper.Map<PetStoreModel>(petStore);
            await _petStoreInterface.AddStore(petStore);
            if(!await _petStoreInterface.Save())
            {
                return StatusCode(500, "Error.");
            }
            var poiReturn = _mapper.Map<PetStoreModel>(lastStore);
            return CreatedAtAction("GetStoreById", new
            {
                id = poiReturn.StoreId
            }, poiReturn);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePetStore(int id, [FromBody] PetStoreModel petStore)
        {
            if(petStore == null)
            {
                return BadRequest();

            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PetStoreModel petStore_ = await _petStoreInterface.GetStoreById(id);
            if(petStore_ == null)
            {
                return NotFound();
            }
            _mapper.Map(petStore, petStore_);
            if(!await _petStoreInterface.Save())
            {
                return StatusCode(500, "Error.");
            }
            return NoContent();
        }

    }
}
