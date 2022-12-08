using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.API.Data;
using HotelListing.API.Contracts;
using AutoMapper;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelsRespository _hotelsRespository;
        private readonly IMapper _mapper;

        public HotelsController(IHotelsRespository hotelsRespository,IMapper mapper)
        {
            
            this._hotelsRespository = hotelsRespository;
            this._mapper = mapper;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDto>>> GetHotels()
        {
            
            var hotels= await _hotelsRespository.GetAllAsync();
            return _mapper.Map<List<HotelDto>>(hotels);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDto>> GetHotel(int id)
        {
            var hotel = await _hotelsRespository.GetAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return _mapper.Map<HotelDto>(hotel); ;
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, HotelDto hotelDto)
           
        {
            var hotel = await _hotelsRespository.GetAsync(id);
            if (hotel is null)
            {
                return BadRequest();
            }
              _mapper.Map(hotelDto, hotel);

            //_context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _hotelsRespository.UpdateAsync(hotel);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(CreateHotelDto createHotelDto)
        {
            var hotel= _mapper.Map<Hotel>(createHotelDto);
            await _hotelsRespository.AddAsync(hotel);

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            var hotel = await _hotelsRespository.GetAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            await _hotelsRespository.DeleteAsync(id);

            return NoContent();
        }

        private bool HotelExists(int id)
        {
            return _hotelsRespository.Exists(id).Result;
        }
    }
}
