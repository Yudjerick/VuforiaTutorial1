using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPositionSetter : MonoBehaviour
{
    public Transform spawnPoint;
    public void SetPosition()
    {
        transform.position = spawnPoint.position;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
