using UnityEngine;

[AddComponentMenu("Playground/Blackboard/Decrement")]
public class BlackboardDecrementAction : BlackboardAction
{
    protected override void PerformAction()
    {
        Blackboard.Sub(variableName, value);
    }
}
