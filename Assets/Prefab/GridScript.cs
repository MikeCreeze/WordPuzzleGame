using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridScript : MonoBehaviour
{
    IEnumerator MyMethod()
    {
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<Image>().enabled = false;

    }

  
    public void SetImage()                    //预制体按钮  
    {
        if (GrobalClass.Steps > 0)
        {


            this.GetComponent<Animator>().CrossFade("Presson", 1f); //播放逐渐缩小动画，调整速度(1为默认，越大越慢)
            StartCoroutine(MyMethod());                             //缩小动画播放完后(0.1秒后)执行隐藏按钮函数(该函数用于延时，为多线程，所以暂时把隐藏的api塞函数里)

            GrobalClass.ChangeSteps(-1);            //步数-1
            
        }
        GameObject TStep = GameObject.Find("文本步数");                         //找到这个文本框后修改内容
        TStep.GetComponent<Text>().text = "剩余步数:" + GrobalClass.Steps;

        
    }

}