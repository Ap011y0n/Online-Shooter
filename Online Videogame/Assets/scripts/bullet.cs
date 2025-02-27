using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody body;
    public float lifetime;
    public float damage = 35;
    public string parent;
    public GameObject impactParticles;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);

    }

    // Update is called once per frame
    void Update()
    {

        body.velocity = transform.forward * speed;
    }
    public void setParent(string obj)
    {
        parent = obj;
    }
    public string returnParent()
    {
        return parent;
    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = transform.position ;
        Instantiate(impactParticles, position, transform.rotation);
        Destroy(this.gameObject);
    }

}
