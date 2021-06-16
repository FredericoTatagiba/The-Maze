using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public static string hasFirstKey = "n";
    public static string hasSecondKey = "n";
    public static string hasThirdKey = "n";

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Main Camera")
        {
            if(gameObject.name == "key1")
            {
                hasFirstKey = "y";
                Destroy(gameObject);
            }

            if(gameObject.name == "keyTrap1")
            {
                Destroy(gameObject); 
                Respawn();
            }

            if(gameObject.name == "keyTrap2")
            {
                Destroy(gameObject); 
                Respawn();
            }

            if(gameObject.name == "keyTrap3")
            {
                Destroy(gameObject); 
                Respawn();
            }

            if((gameObject.name == "FirstDoor") && (hasFirstKey == "y"))
            {
                hasFirstKey = "n";
                Destroy(gameObject);
            }

            if (gameObject.name == "key2")
            {
                hasSecondKey = "y";
                Destroy(gameObject);
            }

            if ((gameObject.name == "SecondDoor") && (hasSecondKey == "y"))
            {
                hasSecondKey = "n";
                Destroy(gameObject);
            }

            if (gameObject.name == "key3")
            {
                hasThirdKey = "y";
                Destroy(gameObject);
            }

            if ((gameObject.name == "ThirdDoor") && (hasThirdKey == "y"))
            {
                hasThirdKey = "n";
                Destroy(gameObject);
            }
        }
    }

    void Respawn()
    {
        player.transform.position = respawnPoint.transform.position;
    }    
}
