using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Main : MonoBehaviour
{
    public GameObject ZJbar;
    public Text GuideText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator NormalMode()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadSceneAsync(1);

    }
    IEnumerator TimeMode()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadSceneAsync(2);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenNormalMode()
    {
        ZJbar.GetComponent<Animator>().CrossFade("左横盖住",0f);//播放动画，并且播放完有0秒的延迟
        StartCoroutine(NormalMode());
    }
    public void OpenTimeMode()
    {

        ZJbar.GetComponent<Animator>().CrossFade("左横盖住", 0f);//播放动画，并且播放完有0秒的延迟
        StartCoroutine(TimeMode());
    }

    public void Guide()                  //介绍
    {
        ZJbar.GetComponent<Animator>().CrossFade("左横盖住", 0f);
        GuideText.GetComponent<Animator>().CrossFade("下落中央", 0f);
    }
    public void CloseGuide()            //关闭介绍
    {
        ZJbar.GetComponent<Animator>().CrossFade("盖住后向右", 0f);
        GuideText.GetComponent<Animator>().CrossFade("中央上升", 0f);
    }

    public void Quit()                  //退出游戏
    {
        Application.Quit();
    }

}
