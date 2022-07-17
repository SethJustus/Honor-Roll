using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionButton : MonoBehaviour
{
    public Event Event;
    private Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();        
    }
    public void SelectOne()
    {

        Event.decision.SelectOption1();
        player.IsClothed = true;

    }
    public void SelectTwo()
    {
        Event.decision.SelectOption2();
        Event.Over = true;
    }
    
}
