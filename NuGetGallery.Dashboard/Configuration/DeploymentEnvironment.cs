﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace NuGetGallery.Dashboard.Configuration
{
    public class DeploymentEnvironment
    {
        [JsonIgnore]
        public string Name { get; set; }

        public string Description { get; set; }
        public Uri Url { get; set; }
        public bool PubliclyVisible { get; set; }
    }
}