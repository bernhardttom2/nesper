///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2015 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;

using com.espertech.esper.client;
using com.espertech.esper.epl.expression.core;
using com.espertech.esper.epl.expression;
using com.espertech.esper.epl.variable;

namespace com.espertech.esper.filter
{
    public class ExprNodeAdapterMultiStreamNoTL : ExprNodeAdapterMultiStream
    {
        public ExprNodeAdapterMultiStreamNoTL(String statementName, ExprNode exprNode, ExprEvaluatorContext evaluatorContext, VariableService variableService, EventBean[] prototype)
            : base(statementName, exprNode, evaluatorContext, variableService, prototype)
        {
        }
    
        public override bool Evaluate(EventBean theEvent)
        {
            if (VariableService != null)
            {
                VariableService.SetLocalVersion();
            }
    
            var eventsPerStream = new EventBean[PrototypeArray.Length];
            Array.Copy(PrototypeArray, 0, eventsPerStream, 0, PrototypeArray.Length);
            eventsPerStream[0] = theEvent;
            return base.EvaluatePerStream(eventsPerStream);
        }
    }
}