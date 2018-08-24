using UnityEngine;

[AddComponentMenu("Playground/Blackboard/Multiply")]
public class BlackboardMultiplyAction : BlackboardAction
{
    protected override void PerformAction()
    {
        Blackboard.Mul(variableName, value);
    }
}
