using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieandplayparticles : MonoBehaviour
{   

    private Vector3 previousPos;
    public float burstsenstivity;

 
    void Die()
    {

        SkinnedMeshRenderer _renderer = this.GetComponent<SkinnedMeshRenderer>();
        _renderer.enabled = false;
        ParticleSystem _particleEmitter = this.GetComponentInChildren<ParticleSystem>();
        _particleEmitter.Play();


        //GetComponent("ParticleRenderer").enabled = true;
        //Can destroy the ganeobject here after our burst animation is complete >>>
        //yield WaitForSeconds(.5);
        //Destroy(gameObject);
    }


    void OnCollisionEnter(Collision col)
    {
      if (col.relativeVelocity.magnitude > burstsenstivity)
          Die();
    }

    /*
     void FixedUpdate()
    {

        if(Vector3.Distance(this.transform.position , previousPos)>2f)
            Die();
        previousPos = this.transform.position;

    }
    */



}
