using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning : MonoBehaviour {
    void OnTriggerEnter()
    {
        gamemng.instance.Win();

    }
}
