using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform hero;
    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(hero.position.x, hero.position.y, transform.position.z);

    }
}
