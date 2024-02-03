///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2024 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

using com.espertech.esper.common.@internal.bytecodemodel.model.expression;
using com.espertech.esper.compat.function;

namespace com.espertech.esper.common.@internal.bytecodemodel.model.statement
{
    public class CodegenStatementCommentFullLine : CodegenStatementBase
    {
        private readonly string _comment;

        public CodegenStatementCommentFullLine(string comment)
        {
            _comment = comment;
        }

        public override void RenderStatement(
            StringBuilder builder,
            bool isInnerClass)
        {
            builder.Append("// ").Append(_comment);
        }

        public override void MergeClasses(ISet<Type> classes)
        {
        }

        public override void TraverseExpressions(Consumer<CodegenExpression> consumer)
        {
        }
    }
} // end of namespace