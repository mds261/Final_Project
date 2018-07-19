using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemng : MonoBehaviour {

    public static gamemng instance = null;

    public GameObject YouWinText;
    public float resetDelay;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }
    public void Win()
    {
        YouWinText.SetActive(true);
        Time.timeScale = .25f;
        Invoke("Reset", resetDelay);
    }

    void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(Application.loadedLevel);
    }
    
}
