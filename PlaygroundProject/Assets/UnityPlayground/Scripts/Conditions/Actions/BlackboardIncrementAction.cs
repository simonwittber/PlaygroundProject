using System.Collections;
using UnityEngine;

[AddComponentMenu("Playground/Blackboard/Increment")]
public class BlackboardIncrementAction : BlackboardAction
{
    protected override void PerformAction()
    {
        Blackboard.Add(variableName, value);
    }
}
