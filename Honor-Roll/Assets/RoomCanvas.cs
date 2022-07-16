using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCanvas : MonoBehaviour
{
    public Room room;
    public Navigation navigation;
    public GameObject canvas;

    void Start()
    {
        navigation = FindObjectOfType<Navigation>();

    }


    void Update()
    {
        if(navigation.currentRoom.Name == room.Name)
        {

            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);

        }
    }
}
