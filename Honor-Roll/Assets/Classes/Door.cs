using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Door : MonoBehaviour
{
    public string Name;
    public Room room;
    public Room leadingRoom;
    public Navigation navigation;
    private void Start()
    {
        navigation = FindObjectOfType<Navigation>();
    }
    void Enter()
    {
        navigation.currentRoom = leadingRoom;
    }

}
