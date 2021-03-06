using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoomText : MonoBehaviour
{
    public Text text;
    public Player player;
    public Room room;

    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if(room.HasBeenEntered)
        {
            text.text = room.ShortDescription;
        }
        else
        {
            text.text = room.Description;
        }
        if(!room.EventX.Over)
        {
            text.text += room.EventX.setting + "\n" + "\n";
        }
        else
        {
            text.text += room.EventX.altSetting + "\n" + "\n";
        }
        

        text.text += room.EventX.decision.outcome;                        

        
        
    }
}
