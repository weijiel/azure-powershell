﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Websites.Utilities;


namespace Microsoft.Azure.Commands.Websites.Models.Websites
{
    public abstract class WebsitesBaseClient : AzurePSCmdlet
    {
        private WebsitesClient _websitesClient;
        public WebsitesClient WebsitesClient
        {
            get
            {
                if (_websitesClient == null)
                {
                    _websitesClient = new WebsitesClient(Profile.Context);
                }
                return _websitesClient;
            }
            set { _websitesClient = value; }
        }
    }
}
