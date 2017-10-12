﻿using FeatureAdmin.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureAdmin.Messages
{
    public class LoadCommand
    {
        public LoadCommand(SPLocation spLocation)
        {
            SPLocation = spLocation;
        }

        public SPLocation SPLocation { get; private set; }
    }
}
