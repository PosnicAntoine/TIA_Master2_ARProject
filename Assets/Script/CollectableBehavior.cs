using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehavior : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject hitParticle;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }
    

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.layer == 10)
        {
            Instantiate(hitParticle, transform.position, transform.rotation);
            this.gameManager.addOnePoint();
            this.gameObject.SetActive(false);
            
        }
    }

}
