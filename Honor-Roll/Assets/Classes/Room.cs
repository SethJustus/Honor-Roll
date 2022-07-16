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
    [SerializeField]
    private Navigation navigation;
    private void Start()
    {
        navigation = FindObjectOfType<Navigation>();

        ICollection<Door> doors = FindObjectsOfType<Door>();

        foreach(Door door in doors)
        {
            if(door.room == this)
            {
                Doors.Add(door);
            }
        }
    }
    

}
