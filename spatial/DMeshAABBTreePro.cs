// Copyright (c) Ryan Schmidt (rms@gradientspace.com) - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited. Proprietary and confidential.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using g3;

namespace gs
{

    /// <summary>
    /// Additions to base DMeshAABBTree3. Currently adds:
    ///    - Fast Mesh Winding Number evaluation
    /// </summary>
    public class DMeshAABBTreePro : DMeshAABBTree3
    {
        public DMeshAABBTreePro(DMesh3 m, bool autoBuild = false) : base(m,autoBuild)
        {
        }

    }
}
