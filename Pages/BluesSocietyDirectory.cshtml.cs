﻿using BluesSocieties.WebSite.Models;
using BluesSocieties.WebSite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BluesSocieties.WebSite.Pages
{
    public class BluesSocietyDirectoryModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileContactService ContactService;
        public IEnumerable<Contact> Contacts { get; set; }

        public BluesSocietyDirectoryModel(
            ILogger<IndexModel> logger,
            JsonFileContactService contactService)

        {
            _logger = logger;
            ContactService = contactService;
        }

        public void OnGet()
        {
            Contacts = ContactService.GetContacts();

        }
    }
}