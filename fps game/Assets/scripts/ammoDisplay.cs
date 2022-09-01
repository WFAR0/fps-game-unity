using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoDisplay : MonoBehaviour
{

    public GameObject ammoTextUI;
   public int pistolCount;
 
    void Update()
    {
        ammoTextUI.GetComponent<Text>().text = pistolCount + "/18";
    }
}
