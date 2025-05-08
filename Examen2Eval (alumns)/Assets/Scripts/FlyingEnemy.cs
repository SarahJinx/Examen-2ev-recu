using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    private float maxTime = 5, currTime = 0;
    public float xSpeed = 1f, ySpeed = 2f;
    private Vector2 dir = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(xSpeed, Mathf.Sin(Time.time) * ySpeed) * Time.deltaTime);
        currTime += Time.deltaTime;
        if (currTime >= maxTime)
        {
            xSpeed *= -1;
            currTime = 0;
        }
    }
}
