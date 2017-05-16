﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamCityTheatre.Core.DataServices;
using TeamCityTheatre.Core.Models;

namespace TeamCityTheatre.Web.Controllers {
  [Route("api/projects")]
  public class ProjectsController : Controller {
    readonly IProjectDataService _projectDataService;

    public ProjectsController(IProjectDataService projectDataService) {
      _projectDataService = projectDataService ?? throw new ArgumentNullException(nameof(projectDataService));
    }

    // GET: api/values
    [HttpGet]
    public async Task<IEnumerable<IBasicProject>> GetAsync() {
      return await _projectDataService.GetAllProjectsAsync();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id) {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value) { }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value) { }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id) { }
  }
}