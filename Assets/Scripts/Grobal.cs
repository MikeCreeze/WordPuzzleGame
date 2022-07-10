using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grobal : MonoBehaviour
{


}
public class GrobalClass:Grobal
 {
    
    public static int NextSteps = 0;   //过关一局后增加步数(基础步数)
    public static int IScore = 0;      //总分数
    public static int Steps   = 0;     //总步数
    public static void ChangeSteps(int st)
    {
        Steps = Steps + st;
    }
    public static void GrobalClassInit()        //初始化
    {
        IScore = 0;
    }

}