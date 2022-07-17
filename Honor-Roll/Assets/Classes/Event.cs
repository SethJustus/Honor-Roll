using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public string Name;
    [TextArea(3,30)]
    public string setting;
    [TextArea(3, 30)]
    public string altSetting;
    public Decision decision;
    
    public bool Over;
    public bool Begun;
    

}
