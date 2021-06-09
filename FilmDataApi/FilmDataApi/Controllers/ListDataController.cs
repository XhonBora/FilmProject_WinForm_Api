using DataService.DTO;
using DataService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListDataController : ControllerBase
    {
        private static string constring = @"Data Source=DESKTOP-EO9O31D;Initial Catalog=FilmProject;Integrated Security=True";
        
        [HttpGet("GetListData")]
        public async Task<IActionResult> GetListData()
        {
            try
            {
                List<ListDataDTO> resultData = ListData.GetListData(constring);
                return Ok(resultData);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException + "->" + ex.Message);
            }
        }

        [HttpGet("GetListDataByName")]
        public async Task<IActionResult> GetListDataByName(string name)
        {
            try
            {
                List<ListDataDTO> dataResult = ListData.GetListDataFromName(name, constring);
                return Ok(dataResult);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException + "->" + ex.Message);
            }
        }

        [HttpPost("PostProducts")]
        public async Task<IActionResult> PostProducts(ListDataDTO dto)
        {
            try
            {
                ListData.PostProducts(dto, constring);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException + "->" + ex.Message);
            }
        }

        [HttpPut("UpdateProducts")]
        public async Task<IActionResult> UpdateProducts(ListDataDTO dto)
        {
            try
            {
                ListData.UpdateProducts(dto, constring);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException + "->" + ex.Message);
            }
        }

        [HttpDelete("DeleteProducts")] 
        public async Task<IActionResult> DeleteProducts(int id)
        {
            try
            {
                ListData.DeleteProducts(id, constring);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException + "->" + ex.Message);
            }
        }
    }
    
}
