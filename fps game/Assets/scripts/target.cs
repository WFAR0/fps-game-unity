
using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 30f;
   
    public void takeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f) 
        {
            die();
        } 
    }
    void die () 
    {
        Destroy(gameObject);
    }

}
