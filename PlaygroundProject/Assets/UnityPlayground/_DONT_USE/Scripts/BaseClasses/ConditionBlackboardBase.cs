using UnityEngine;

public abstract class ConditionBlackboardBase : ConditionBase
{
    public string variableName;
    public int value;
    public float timeBetweenChecks = 1;

    float timeLastEventFired = float.MinValue;

    protected abstract bool ConditionCheck();

    private void Update()
    {
        if (Time.time - timeLastEventFired >= timeBetweenChecks)
        {
            if (ConditionCheck())
                ExecuteAllActions(null);
            timeLastEventFired = Time.time;
        }
    }
}

