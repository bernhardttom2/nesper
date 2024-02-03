///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2024 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;

using com.espertech.esper.common.@internal.compile.stage3;

namespace com.espertech.esper.common.@internal.compile.stage2
{
    public class FilterSpecCompiledDesc
    {
        public FilterSpecCompiledDesc(
            FilterSpecCompiled filterSpecCompiled,
            IList<StmtClassForgeableFactory> additionalForgeables)
        {
            FilterSpecCompiled = filterSpecCompiled;
            AdditionalForgeables = additionalForgeables;
        }

        public FilterSpecCompiled FilterSpecCompiled { get; }

        public IList<StmtClassForgeableFactory> AdditionalForgeables { get; }
    }
} // end of namespace