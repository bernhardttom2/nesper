///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2019 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;

namespace com.espertech.esper.common.@internal.bytecodemodel.model.expression
{
    public class CodegenExpressionTypePair
    {
        public CodegenExpressionTypePair(
            Type type,
            CodegenExpression expression)
        {
            Type = type;
            Expression = expression;
        }

        public Type Type { get; }

        public CodegenExpression Expression { get; }
    }
} // end of namespace