using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
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

    IEnumerator Delay()
    {
        var newgo = Instantiate(Ball, targetPosition, Quaternion.identity);
        Destroy(Ball);
        newgo.name = "Bolinha poggers :)";
        yield return null;
    }

}
