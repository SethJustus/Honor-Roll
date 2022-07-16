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

    public List<Decision> Decisions;
    public List<Door> Doors;
    public Canvas Canvas;
    [SerializeField]
    private Navigation navigation;
    private void Start()
    {
        navigation = FindObjectOfType<Navigation>();
    }

}
