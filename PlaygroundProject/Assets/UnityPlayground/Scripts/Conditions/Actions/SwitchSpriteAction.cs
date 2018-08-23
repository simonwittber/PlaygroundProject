using UnityEngine;

[AddComponentMenu("Playground/Actions/Switch Sprite")]
public class SwitchSpriteAction : Action
{
    [Tooltip("If not set, the sprite renderer on the current GameObject is used.")]
    public SpriteRenderer spriteRendererToChange;

    [Tooltip("The list of sprites to change to each time the action is executed.")]
    public Sprite[] spriteList;

    [Tooltip("The minimum time in seconds between successive executions of this action.")]
    public float minTimeBetweenAction = 0.5f;

    private int spriteIndex;
    private float lastExecuteTime;

    void Awake()
    {
        if (spriteRendererToChange == null) spriteRendererToChange = GetComponent<SpriteRenderer>();
    }

    public override bool ExecuteAction(GameObject otherObject)
    {
        if (spriteRendererToChange != null)
        {
            if (spriteList.Length > 0)
            {
                var timeSinceLastAction = Time.time - lastExecuteTime;
                if (timeSinceLastAction < minTimeBetweenAction)
                {
                    //Exit this method, but still return true so that other actions
                    //will continue to run.
                    return true;
                }
                spriteRendererToChange.sprite = spriteList[spriteIndex];
                spriteIndex = spriteIndex + 1;
                if (spriteIndex >= spriteList.Length)
                {
                    spriteIndex = 0;
                }
                lastExecuteTime = Time.time;
                return true;
            }
        }
        return false;
    }
}
