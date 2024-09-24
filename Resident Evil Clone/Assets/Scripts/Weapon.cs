using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int ammoCapacity;
    [SerializeField] protected int currrentLoadedAmmo;
    [SerializeField] protected int currrentSpareAmmo;
    [SerializeField] protected bool canFire;
    [SerializeField] protected Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Reload()
    {
        if (currrentLoadedAmmo < ammoCapacity)
        {
            if(currrentSpareAmmo > 0)
            {
                int difference = ammoCapacity - currrentLoadedAmmo;
                if(currrentSpareAmmo >= difference)
                {
                    currrentLoadedAmmo = ammoCapacity;
                    currrentSpareAmmo -= difference;
                }
                else
                {
                    currrentLoadedAmmo += currrentSpareAmmo;
                }
            }
            
        }
    }

    protected virtual void Fire()
    {
        RaycastHit hit;

        if (Physics.Raycast(firePoint.position, firePoint.forward, out hit, 100))
        {
            Debug.DrawRay(firePoint.position, firePoint.forward * hit.distance, Color.red, 2f);
            if (hit.transform.CompareTag("Zombie"))
            {
                hit.transform.GetComponent<Enemy>().TakeDamage(1);
            }
        }
    }
}
