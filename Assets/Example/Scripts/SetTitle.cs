using AdvancedSceneManager.Callbacks;
using AdvancedSceneManager.Models;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SetTitle : MonoBehaviour, ICollectionOpen
{
    public Text text;
    // Start is called before the first frame update

    public IEnumerator OnCollectionOpen(SceneCollection collection)
    {
        if (text != null)
            text.text = collection.ExtraData<ExtraDataASM>().levelName;

        yield break;
    }
}