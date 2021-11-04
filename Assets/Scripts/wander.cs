using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wander : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(StartWandering());
    }

    IEnumerator StartWandering()
    {
        while (true)
        {
            // Wander
            yield return Wander();

            // Wait for x seconds until I wander again
            yield return new WaitForSeconds(Random.Range(0f, 3f));
        }
    }

    IEnumerator Wander()
    {
        rb.velocity = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
        yield return new WaitForSeconds(.5f);
        rb.velocity = new Vector2(0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Debug.Log("Collision!");
       // Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "static ink(Clone)")
        {
           // Debug.Log("From a static inkl!");
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(gameObject);
            ScoreManager.Instance.DecreaseCount(1);
        }
    }
}
