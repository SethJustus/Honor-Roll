using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsClothed;
    public bool HasKnife;
    public Event playerIsntClothedInRoom;
    public Event playerIsntClothedInHallway;
    public Event playerPeacefulGuard;
    private void Update()
    {
        if(IsClothed)
        {
            playerIsntClothedInRoom.Over = true;
            playerIsntClothedInHallway.Over = true;
        }
        else 
        {
            playerPeacefulGuard.Begun = true;
        }
       
    }
}
