using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour, IPickupable
{
    [SerializeField] int maxCapacity;
    [SerializeField] int currentCount;
    [SerializeField] Enums.MagazineType magazineType;

    /*
    public enum MagazineType
    {
        Rifle,
        Pistol,
        Shotgun
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveRound()
    {
        if (currentCount > 0)
        {
            currentCount--;
        }
    }

    public Enums.MagazineType GetMagazineType()
    {
        return magazineType;
    }

    public void Pickup(PlayerController player)
    {
        gameObject.SetActive(false);
    }

    public int GetRounds()
    {
        return currentCount;
    }
}
