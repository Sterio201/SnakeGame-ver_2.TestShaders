using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvL : MonoBehaviour
{
    [SerializeField] GameObject loadScene;

    public void LoadLvLButton(int nomer)
    {
        if(loadScene != null)
        {
            loadScene.SetActive(true);
            StartCoroutine(AnimationLoading(nomer));
        }
        else
        {
            Time.timeScale = 1f;
            PlayerSettings.nomerShiftScene = nomer;
            SceneManager.LoadScene("LoadingScene");
        }
    }

    IEnumerator AnimationLoading(int nomer)
    {
        loadScene.GetComponent<Animator>().Play("StartAnim");
        yield return new WaitForSeconds(0.9f);

        Time.timeScale = 1f;
        PlayerSettings.nomerShiftScene = nomer;
        SceneManager.LoadScene("LoadingScene");
    }
}