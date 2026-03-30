using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody rb;
    private GameObject player;
    private bool isStunned;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Start()
    {

    }

    void Update()
    {
        if (isStunned) return;

        Vector3 dir = player.transform.position - transform.position;
        dir.Normalize();
        rb.AddForce(dir * speed);
    }

    public void ApplyStun(float duration)
    {
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(StunRoutine(duration));
        }
    }

    IEnumerator StunRoutine(float duration)
    {
        isStunned = true;

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;

            rb.angularVelocity = Vector3.zero;
        }

        yield return new WaitForSeconds(duration);

        isStunned = false;
    }
}
