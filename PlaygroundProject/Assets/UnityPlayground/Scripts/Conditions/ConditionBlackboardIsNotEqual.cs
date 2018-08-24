using UnityEngine;

[AddComponentMenu("Playground/Conditions/Blackboard/IsNotEqual")]
public class ConditionBlackboardIsNotEqual : ConditionBlackboardBase
{
    protected override bool ConditionCheck()
    {
        return Blackboard.IsNotEqual(name, value);
    }
}

