// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.TrafficManager.Models;

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    /// <summary>
    /// A region in the Traffic Manager Geographic Hierarchy that can be used
    /// with the Geographic Traffic Routing Method.
    /// </summary>
    public partial class RegionalGrouping : GeographicEntity
    {
        private IList<CountryRegion> _regions;
        
        /// <summary>
        /// Optional. Gets or sets the list of Regions grouped under this
        /// Region in the Geographic Hierarchy.
        /// </summary>
        public IList<CountryRegion> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RegionalGrouping class.
        /// </summary>
        public RegionalGrouping()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RegionalGrouping class with
        /// required arguments.
        /// </summary>
        public RegionalGrouping(string code)
            : this()
        {
            if (code == null)
            {
                throw new ArgumentNullException("code");
            }
            this.Code = code;
        }
    }
}