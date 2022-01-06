using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static int currentLevel=0;

    // Use this for initialization
    [System.Obsolete]
    public static void CompleteLevel()
    {
        currentLevel += 1;
        Application.LoadLevel(currentLevel);
    }
}
