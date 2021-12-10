using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerConstruct : MonoBehaviour
{

    public GameObject Block;


    void Start()
    {
        StartCoroutine(Builder());
    }


    IEnumerator Builder()
    {

        float w = 0.026f;
        float h = 0.0151f;
        
        yield return null;
        
        for (int i = 0; i < 30; ++i)
        {
            
            yield return new WaitForSeconds(0.01f);
            
            Instantiate(Block, transform.position + new Vector3(w, h * i * 2, 0.0f), transform.localRotation).transform.parent = transform;
            Instantiate(Block, transform.position + new Vector3(0.0f, h * i * 2, 0.0f), transform.localRotation).transform.parent = transform;
            Instantiate(Block, transform.position + new Vector3(-w, h * i * 2, 0.0f), transform.localRotation).transform.parent = transform;

            yield return new WaitForSeconds(0.01f);
            
            Instantiate(Block, transform.position + new Vector3(0.0f, h * (2 * i + 1), w), transform.localRotation * Quaternion.Euler(0.0f, 90.0f, 0.0f)).transform.parent = transform;
            Instantiate(Block, transform.position + new Vector3(0.0f, h * (2 * i + 1), 0.0f), transform.localRotation * Quaternion.Euler(0.0f, 90.0f, 0.0f)).transform.parent = transform;
            Instantiate(Block, transform.position + new Vector3(0.0f, h * (2 * i + 1), -w), transform.localRotation * Quaternion.Euler(0.0f, 90.0f, 0.0f)).transform.parent = transform;
            
            
            
        }

        yield return null;
    }



}
