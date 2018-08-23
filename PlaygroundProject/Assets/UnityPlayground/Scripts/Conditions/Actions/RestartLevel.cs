using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu("Playground/Actions/Restart Level")]
public class RestartLevel : Action
{

    public override bool ExecuteAction(GameObject otherObject)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        return true;
    }
}