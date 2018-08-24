using UnityEngine;

[AddComponentMenu("Playground/Conditions/Blackboard/IsLessThanOrEqual")]
public class ConditionBlackboardIsLessThanOrEqual : ConditionBlackboardBase
{
    protected override bool ConditionCheck()
    {
        return Blackboard.IsLessThanOrEqual(name, value);
    }
}

