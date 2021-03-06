﻿using Flunt.Validations;
using System.Collections.Generic;

namespace AppFullStackDemo.Domain.Entities
{
    public class Manufacturer : EntityBase
    {
        public Manufacturer(string description)
        {
            Description = description;
        }

        protected Manufacturer() { } //This constructor will be used by EF during migrations (for some reason, EF needs a empty constructor to run)

        //Parameters and ObjectValues
        public string Description { get; private set; }

        //Manufacturer has a collection of ManufacturerCategories
        public List<DeviceModel> DevicesModel { get; private set; }

        public void Update(string description)
        {
            Description = description;
        }
    }
}