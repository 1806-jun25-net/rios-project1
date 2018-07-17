﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.WebApp.Models
{
    public class LocationModel
    {
        public int LocationId { get; set; }

        
        public string Name { get; set; }

        public SelectListItem SelectedLocation { get; set;  }




    }
}
