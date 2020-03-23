using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Screen2Loader : MonoBehaviour
{
    [SerializeField]
    private Text progressText;
    [SerializeField]
    private Slider slider;

    private AsyncOperation operation;
    private Canvas canvas;

    private void Awake()
    {
        //connect to canvas
        canvas = GetComponentInChildren<Canvas>(true);
    }

    public void LoadScene2(string sceneName)
    {
        //set progress to 0
        UpdateProgressUI(0);
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
        while (!operation.isDone)
        {
            UpdateProgressUI(operation.progress);
            yield return null;
        }

        UpdateProgressUI(operation.progress);

        //done with scene loader
        operation = null;

        //hide canvas
        canvas.gameObject.SetActive(false);
    }

    private void UpdateProgressUI(float progress)
    {
        //set slider length to amount of progress laoding screen
        slider.value = progress;
        //set progress text to amount of progress laoding screen
        progressText.text = (int)(progress * 100f) + "%";
    }
}
