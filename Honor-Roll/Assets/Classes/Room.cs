using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Room : MonoBehaviour
{
    public string Name;
    [HideInInspector]
    public bool HasBeenEntered = false;
    [TextArea(4, 20)]
    public string Description;
    [TextArea(4,10)]
    public string ShortDescription;
    public bool hasClown;

    private Navigation navigation;
    public Event EventX;

    private void Start()
    {
        navigation = FindObjectOfType<Navigation>();
    }

}
