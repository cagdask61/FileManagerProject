using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemFilesController : ControllerBase
    {
        private readonly ISystemFileService _systemFileService;
        public SystemFilesController(ISystemFileService systemFileService)
        {
            _systemFileService = systemFileService;
        }

        [HttpPost("upload")]
        public IActionResult Upload([FromForm] UserForFile file)
        {
            var result = _systemFileService.Upload(file);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("delete")]
        public IActionResult Delete(SystemFile systemFile)
        {
            var result = _systemFileService.Delete(systemFile);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(SystemFile systemFile)
        {
            var result = _systemFileService.Update(systemFile);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("create-folder")]
        public IActionResult CreateFolder(SystemFolder systemFolder)
        {
            var result = _systemFileService.CreateFolder(systemFolder);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
                
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _systemFileService.GetAll();
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
