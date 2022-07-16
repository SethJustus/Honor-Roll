using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Room : MonoBehaviour
{
    public string Name;
    [HideInInspector]
    public bool HasBeenEntered;
    [TextArea(4, 20)]
    public string Description;
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
