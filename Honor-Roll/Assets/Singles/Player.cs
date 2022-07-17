using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsClothed;
    public bool HasKnife;
    public Event playerIsntClothedInRoom;
    public Event playerIsntClothedInHallway;
    private void Update()
    {
        if(IsClothed)
        {
            playerIsntClothedInRoom.Over = true;
            playerIsntClothedInHallway.Over = true;
        }
       
    }
}
