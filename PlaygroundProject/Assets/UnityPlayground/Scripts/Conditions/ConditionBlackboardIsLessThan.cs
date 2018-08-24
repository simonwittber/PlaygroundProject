using UnityEngine;

[AddComponentMenu("Playground/Conditions/Blackboard/IsLessThan")]
public class ConditionBlackboardIsLessThan : ConditionBlackboardBase
{
    protected override bool ConditionCheck()
    {
        return Blackboard.IsLessThan(name, value);
    }
}

