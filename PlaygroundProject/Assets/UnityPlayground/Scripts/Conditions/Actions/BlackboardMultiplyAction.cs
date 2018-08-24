using UnityEngine;

[AddComponentMenu("Playground/Actions/Blackboard/Multiply")]
public class BlackboardMultiplyAction : BlackboardAction
{
    protected override void PerformAction()
    {
        Blackboard.Mul(variableName, value);
    }
}
