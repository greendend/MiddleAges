﻿using MiddleAges.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MiddleAges.Entities
{
    public class LandBuilding
    {
        [Key]
        public Guid BuildingId { get; set; }
        public string LandId { get; set; }
        public LandBuildingType BuildingType { get; set; }
        public int Lvl { get; set; }
        public Land Land { get; set; }
    }
}
