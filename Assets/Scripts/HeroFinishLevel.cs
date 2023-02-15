using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFinishLevel : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("candy"))
        {
            anim.SetTrigger("finish");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
