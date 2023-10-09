using System.Linq;
using AdvancedSceneManager.Models;
using UnityEngine;


public class LevelSelector : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        // Grab all collections that contains the word "Level"
        var Search = Profile.current.collections.Where(c => c.name.Contains("Level"));

        // Instanciate a button for each collection, and add image and text from User data.
        foreach (var item in Search)
        {
            GameObject newbutton = Instantiate(prefab, transform);
            UserDataASM data = (UserDataASM)item.userData;
            newbutton.GetComponent<LevelSelectorButton>().ApplyData(data.levelName, item);
        }
    }
}
