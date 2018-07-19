using UnityEngine;
using System.Collections;

public class count : MonoBehaviour
{
    public float resetDelay;
    float timeRemaining = 300.0f;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
    }

    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100),
                         "Time Remaining : " + timeRemaining);
        }
        else
        {

            GUI.Label(new Rect(100, 100, 200, 100), "You Failed to Escape!");
            Application.LoadLevel(Application.loadedLevel);
        }

         
        
    }
}


    

    

        
    
    
