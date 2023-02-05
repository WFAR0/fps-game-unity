using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoDisplay : MonoBehaviour
{
    public Text ammoTextUI;
    public pistolFire script;

    void update() {
        ammoTextUI.text = script.currAmmo + "/18";
    }
}
