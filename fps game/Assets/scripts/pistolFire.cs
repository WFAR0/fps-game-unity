using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject muzzleFlash;
    public AudioSource pistolShot;
    public AudioClip pistolShotSound;
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
  




void start() 
{
    pistolShot = GetComponent<AudioSource>();
}

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }

        void shoot () {    
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
        isFiring = true;
        Target target = hit.transform.GetComponent<Target>();
        if (target != null) 
        {
            target.takeDamage;
        }
        blackPistol.GetComponent<Animator>().Play("firePistol");
        pistolShot.PlayOneShot(pistolShotSound);
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.015f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.13f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring = false;
        }
        }
    }



  
}
