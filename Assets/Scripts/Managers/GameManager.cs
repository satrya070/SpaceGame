using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool QuitGame => Input.GetKeyUp(KeyCode.Escape);

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    void Update()
    {
        if (QuitGame)
        {
            Debug.Log("quit game");
            ExitGame();
        }
    }

    void ExitGame()
    {
        # if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // handles webGL
            Application.Quit();
        # endif
    }
}
