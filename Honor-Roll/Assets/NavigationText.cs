using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NavigationText : MonoBehaviour
{
    public Text text;
    public Navigation navigation;
    private void Start()
    {
        text = GetComponent<Text>();
        navigation = FindObjectOfType<Navigation>();
    }
    private void Update()
    {
        text.text = navigation.currentRoom.Name;
    }
}
