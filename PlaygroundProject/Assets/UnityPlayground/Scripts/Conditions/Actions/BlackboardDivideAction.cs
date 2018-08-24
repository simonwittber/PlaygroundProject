using UnityEngine;

[AddComponentMenu("Playground/Actions/Blackboard/Divide")]
public class BlackboardDivideAction : BlackboardAction
{
    protected override void PerformAction()
    {
        Blackboard.Div(variableName, value);
    }
}