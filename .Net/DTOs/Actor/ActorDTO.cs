﻿using System;
using System.Collections.Generic;
using DTOs.Shared;


namespace DTOs.Actor
{
    public class ActorDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

        public ICollection<Shared.Movie> Movies { get; set; }
    }

    
}
