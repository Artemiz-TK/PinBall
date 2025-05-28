using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCheckerController : MonoBehaviour
{
    public GameObject Ball;
    public Transform transformBall;
    public BoxCollider2D ground;
    public Vector3 targetPosition;

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(Delay());
            print(c.name);
        }
    }

    void Update()
    {
        if (!Ball.activeInHierarchy)
        {
            Ball = GameObject.Find("Bolinha poggers :)");
            Ball.SetActive(true);
            Debug.ClearDeveloperConsole();
        }
    }

    IEnumerator Delay()
    {
        Ball.gameObject.SetActive(false);

        yield return new WaitForSeconds(0.060f);

        yield return null;

        transformBall.position = targetPosition;
        yield return new WaitForSeconds(0.2f);
        Ball.gameObject.SetActive(true);
    }
}
