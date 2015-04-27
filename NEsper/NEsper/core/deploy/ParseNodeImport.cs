///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2015 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;

namespace com.espertech.esper.core.deploy
{
    public class ParseNodeImport : ParseNode
    {
        public ParseNodeImport(EPLModuleParseItem item, String imported)
            : base(item)
        {
            Imported = imported;
        }

        public string Imported { get; private set; }
    }
}