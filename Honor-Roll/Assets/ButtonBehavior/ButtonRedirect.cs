using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonRedirect : MonoBehaviour
{
    private Button button;
    public string scene;
    void Start()
    {
        button = GetComponent<Button>();
    }

    public void Navigate ()
    {
        SceneManager.LoadScene(scene);
    }
}
