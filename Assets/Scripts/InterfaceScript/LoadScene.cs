using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] Image progressBar;
    AsyncOperation loadingSceneOperation;

    private void Start()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(1f);
        loadingSceneOperation = SceneManager.LoadSceneAsync(PlayerSettings.nomerShiftScene);
        float progress = 0f;

        while (!loadingSceneOperation.isDone)
        {
            progress = loadingSceneOperation.progress / 0.9f;
            progressBar.fillAmount = progress;
            yield return 0;
        }
    }
}