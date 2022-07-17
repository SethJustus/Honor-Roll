using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCanvas : MonoBehaviour
{
    public Room room;
    public Navigation navigation;
    public GameObject canvas;
    public GameObject EventCanvas;
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
        if(room.EventX.Begun&& !room.EventX.Over)
        {
            EventCanvas.SetActive(true);
        }
        else
        {
            EventCanvas.SetActive(false);
        }
    }
}
