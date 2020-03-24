using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreen3 : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Portal"))
        {
            FindObjectOfType<Screen3Loader>().LoadScene3(sceneToLoad);
        }
    }
}
