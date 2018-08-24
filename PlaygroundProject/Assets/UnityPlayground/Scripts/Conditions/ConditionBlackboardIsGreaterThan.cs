using UnityEngine;

[AddComponentMenu("Playground/Conditions/Blackboard/IsGreaterThan")]
public class ConditionBlackboardIsGreaterThan : ConditionBlackboardBase
{
    protected override bool ConditionCheck()
    {
        return Blackboard.IsGreaterThan(name, value);
    }
}

