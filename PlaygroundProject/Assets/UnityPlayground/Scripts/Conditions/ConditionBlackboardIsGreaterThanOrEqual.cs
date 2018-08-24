using UnityEngine;

[AddComponentMenu("Playground/Conditions/Blackboard/IsGreaterThanOrEqual")]
public class ConditionBlackboardIsGreaterThanOrEqual : ConditionBlackboardBase
{
    protected override bool ConditionCheck()
    {
        return Blackboard.IsGreaterThanOrEqual(name, value);
    }
}

