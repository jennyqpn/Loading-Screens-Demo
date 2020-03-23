using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreen2 : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Portal"))
        {
            FindObjectOfType<Screen2Loader>().LoadScene2(sceneToLoad);
        }
    }
}
