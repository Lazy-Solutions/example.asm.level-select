using AdvancedSceneManager.Models;
using AdvancedSceneManager.Utility;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectorButton : MonoBehaviour
{
    public Text description;
    SceneCollection collection;

    public void OpenLevel()
    {
        SceneHelper.current.Open(collection);
    }

    public void ApplyData(string text, SceneCollection collection)
    {
        description.text = text;
        this.collection = collection;
    }
}
