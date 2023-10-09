using System.Collections;
using AdvancedSceneManager.Callbacks;
using AdvancedSceneManager.Models;
using UnityEngine;
using UnityEngine.UI;

public class SetTitle : MonoBehaviour, ICollectionOpenAsync
{
    public Text text;
    // Start is called before the first frame update

    public IEnumerator OnCollectionOpen(SceneCollection collection)
    {
        if (text != null)
            text.text = collection.UserData<UserDataASM>().levelName;

        yield break;
    }
}