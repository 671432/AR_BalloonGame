using System.Collections;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DestroyBalloons());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
    }

    IEnumerator DestroyBalloons()
    {
        yield return new WaitForSeconds(10);

        Destroy(gameObject);
    }
}
