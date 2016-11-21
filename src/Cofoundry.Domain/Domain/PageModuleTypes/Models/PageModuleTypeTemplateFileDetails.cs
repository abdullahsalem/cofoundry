﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Domain
{
    /// <summary>
    /// Represents the result of parsing a page module template view file
    /// for information.
    /// </summary>
    public class PageModuleTypeTemplateFileDetails
    {
        /// <summary>
        /// The display name for the template in the administration UI
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the template in the administration UI
        /// </summary>
        public string Description { get; set; }
    }
}