﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;

namespace RazorWebSite.Controllers
{
    public class ViewWithPathsController : Controller
    {
        [HttpGet("/ViewWithPaths")]
        public IActionResult Index()
        {
            return View();
        }
    }
}