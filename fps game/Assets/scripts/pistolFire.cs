using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolFire : MonoBehaviour
{
     public GameObject blackPistol;
    public bool isFiring = false;
    public ParticleSystem muzzleFlash;
    public AudioSource pistolShot;   
    public AudioClip gunshot;
    public int maxAmmo = 18;
    public int currAmmo;
    private bool isReloading = false;
    void Update()
    {

        if(isReloading = false) 
        return;

        if(currAmmo <= 0) 
        {
             StartCoroutine(Reload());
            return;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
    
    }

    IEnumerator FireThePistol()
    {
        currAmmo--;
        isFiring = true;
        blackPistol.GetComponent<Animator>().Play("firePistol");
       pistolShot.PlayOneShot(gunshot);
        muzzleFlash.Play(true);
        yield return new WaitForSeconds(0.13f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }

    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("reloading...");
         blackPistol.GetComponent<Animator>().Play("pistolReload");
        yield return new WaitForSeconds(1f);   
        currAmmo = maxAmmo;
        isReloading = false;

    } 
}


