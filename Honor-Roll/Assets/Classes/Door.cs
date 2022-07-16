using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Door : MonoBehaviour
{
    public string Name;
    public Room room;
    public Room leadingRoom;
    public Navigation navigation;
    public bool Locked;
    public Button button;
    private void Start()
    {
        navigation = FindObjectOfType<Navigation>();
        button = GetComponent<Button>();
    }
    public void Enter()
    {
        if(!Locked)
        {
            navigation.currentRoom = leadingRoom;
            room.HasBeenEntered = true;
        }
        
    }
    private void Update()
    {
        if(Locked)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
        
    }

}
