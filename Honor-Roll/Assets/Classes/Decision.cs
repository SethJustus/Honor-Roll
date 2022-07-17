using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Decision : MonoBehaviour
{
    [HideInInspector]
    public string outcome;
    [TextArea(1, 20)]
    public string possibilityOne;
    [TextArea(1, 20)]
    public string possibilityTwo;
    public void SelectOption1()
    {
        outcome = possibilityOne;
    }
    public void SelectOption2()
    {
        outcome = possibilityTwo;
    }
}
