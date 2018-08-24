using UnityEngine;

public abstract class BlackboardAction : Action
{
    public string variableName;
    public int value;
    abstract protected void PerformAction();

    public override bool ExecuteAction(GameObject dataObject)
    {
        PerformAction();
        return true;
    }
}
