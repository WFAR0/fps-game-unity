using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoDisplay : MonoBehaviour
{
    public GameObject ammoTextUI;
    public pistolFire script;

    void start () {
        
    }

    void update() {
        ammoTextUI.GetComponent<Text>().text = script.currAmmo + "/18";
    }
}
