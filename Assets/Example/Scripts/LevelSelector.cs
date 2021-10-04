using AdvancedSceneManager.Models;
using System.Linq;
using UnityEngine;


public class LevelSelector : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        var Search = Profile.current.collections.Where(c => c.name.Contains("Level_"));

        foreach (var item in Search)
        {
            GameObject newbutton = Instantiate(prefab, transform);
            ExtraDataASM data = (ExtraDataASM)item.extraData;
            newbutton.GetComponent<LevelSelectorButton>().ApplyData(data.levelName, item);
        }
    }
}
