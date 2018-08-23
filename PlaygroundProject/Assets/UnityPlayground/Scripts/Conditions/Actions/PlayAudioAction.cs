using UnityEngine;

[AddComponentMenu("Playground/Actions/Play Audio")]
public class PlayAudioAction : Action
{
    public AudioClip audioClipToPlay;
    public float volume = 0.75f;

    [Tooltip("The minimum time in seconds between successive executions of this action.")]
    public float minTimeBetweenAction = 0.5f;

    private float lastExecuteTime;

    public override bool ExecuteAction(GameObject otherObject)
    {
        if (audioClipToPlay != null)
        {
            var timeSinceLastAction = Time.time - lastExecuteTime;
            if (timeSinceLastAction < minTimeBetweenAction)
            {
                //Exit this method, but still return true so that other actions
                //will continue to run.
                return true;
            }
            AudioSource.PlayClipAtPoint(audioClipToPlay, transform.position, volume);
            lastExecuteTime = Time.time;
            return true;
        }
        return false;
    }
}
