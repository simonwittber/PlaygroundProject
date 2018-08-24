using UnityEngine;

[AddComponentMenu("Playground/Conditions/Blackboard/IsEqual")]
public class ConditionBlackboardIsEqual : ConditionBlackboardBase
{
    protected override bool ConditionCheck()
    {
        return Blackboard.IsEqual(name, value);
    }
}

