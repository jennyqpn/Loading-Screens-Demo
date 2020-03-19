using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Screen4Loader : MonoBehaviour
{
    private AsyncOperation operation;
    private Canvas canvas;
    
    private void Awake()
    {
        //connect to canvas
        canvas = GetComponentInChildren<Canvas>(true);
    }

    public void LoadScene4(string sceneName)
    {
        //show loading screen
        canvas.gameObject.SetActive(true);
        
        //keep loading screen up until next scene is done loading
        StartCoroutine(BeginLoad(sceneName));
    }

    private IEnumerator BeginLoad(string sceneName)
    {
        yield return new WaitForSeconds(10);

        //get scene loader
        operation = SceneManager.LoadSceneAsync(sceneName);

        //while scene isn't done loading, return null
        while(!operation.isDone)
        {
            yield return null;
        }

        //done with scene loader
        operation = null;

        

        //hide canvas
        canvas.gameObject.SetActive(false);
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
