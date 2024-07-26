using System.Linq;
using AdvancedSceneManager.Callbacks;
using AdvancedSceneManager.Models;
using UnityEngine;

public class LevelSelector : MonoBehaviour, ISceneOpen
{

    public GameObject panel;
    public GameObject prefab;

    public void OnSceneOpen()
    {

        panel.SetActive(true);

        // Grab all collections that contains the word "Level"
        var Search = Profile.current.collections.Where(c => c.name.Contains("Level"));

        // Instanciate a button for each collection, and add image and text from User data.
        foreach (var item in Search)
        {
            var newbutton = Instantiate(prefab, panel.transform);
            var data = (UserDataASM)item.userData;
            newbutton.GetComponent<LevelSelectorButton>().ApplyData(data.levelName, item);
        }

    }

}
