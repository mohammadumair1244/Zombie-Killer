using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject PlayerCam;
    public AudioSource aud;
    public float range=100f;
    public float damage=50f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            // Debug.Log("Pressed");
            Shoot();
        //   StartCoroutine(Gun());
        }
    }

void Shoot(){
    aud.Play();
    RaycastHit hit;
    if (Physics.Raycast(PlayerCam.transform.position, transform.TransformDirection(Vector3.forward), out hit,range))
    {
        EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
        if (enemyManager!=null)
        {
            enemyManager.Hit(damage);
        }
    }
}
    // IEnumerator Gun()
    // {    
    //     aud.Play();
    //     RaycastHit hit;
    //     if (Physics.Raycast(PlayerCam.transform.position, transform.TransformDirection(Vector3.forward), out hit,range))
    //     {
    //        Debug.Log("Hit"); 
    //         // if (hit.collider.tag == "Enemy")
    //         // {
    //         //     hit.collider.GetComponent<Enemy>().TakeDamage(10);
    //         // }
    //     }

        // GetComponent<Animator>().Play("recoil");
        // yield return new WaitForSeconds(0.25f);
        // GetComponent<Animator>().Play("idle");}
}

