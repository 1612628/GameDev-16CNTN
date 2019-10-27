using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public SceneController sceneController;

    public void playGame()
    {
        sceneController.gotoIngameScene1();
    }
}
