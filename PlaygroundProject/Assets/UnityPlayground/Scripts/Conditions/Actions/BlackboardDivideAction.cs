using UnityEngine;

[AddComponentMenu("Playground/Blackboard/Divide")]
public class BlackboardDivideAction : BlackboardAction
{
    protected override void PerformAction()
    {
        Blackboard.Div(variableName, value);
    }
}