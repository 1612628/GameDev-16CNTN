using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{

    public void gotoIngame()
    {
        SceneManager.LoadScene(2);
    }
}
