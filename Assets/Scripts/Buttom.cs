using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Word
{
    public string Data = null;
    public bool IfBeChoose = false;
    public Word(string Da)
    {
        Data = Da;
    }
}

public class Buttom : MonoBehaviour
{

    public bool GameBadEnd=false;    //游戏是否开始，用于检测失败
    public InputField Answer;        //指向输入框回答
    public Text NeedAnswerWord;      //指向输出正确答案的文本(暂时用这个与玩家答案核对)
    public Text Score;               //指向输入框回答
    public Text Msg;                 
    public Text TStep;               //剩余步数
    public Text Level;               //进展到第几关

    public Word[] WordBase = { new Word("寿"), new Word("弄"), new Word("麦"), new Word("形"), new Word("进"), new Word("戒"), new Word("吞"), new Word("远"), new Word("违"), new Word("运"), new Word("扶"), new Word("抚"), new Word("坛"), new Word("技"), new Word("坏"), new Word("扰"), new Word("拒"), new Word("找"), new Word("批"), new Word("扯"), new Word("址"), new Word("走"), new Word("抄"), new Word("坝"), new Word("贡"), new Word("攻"), new Word("赤"), new Word("折"), new Word("抓"), new Word("扮"), new Word("抢"), new Word("孝"), new Word("抛"), new Word("投"), new Word("坟"), new Word("抗"), new Word("坑"), new Word("坊"), new Word("抖"), new Word("护"), new Word("壳"), new Word("志"), new Word("扭"), new Word("块"), new Word("声"), new Word("把"), new Word("报"), new Word("却"), new Word("劫"), new Word("芽"), new Word("花"), new Word("芹"), new Word("芬"), new Word("苍"), new Word("芳"), new Word("严"), new Word("芦"), new Word("劳"), new Word("克"), new Word("苏"), new Word("杆"), new Word("杠"), new Word("杜"), new Word("材"), new Word("村"), new Word("杏"), new Word("极"), new Word("李"), new Word("杨"), new Word("求"), new Word("更"), new Word("束"), new Word("豆"), new Word("两"), new Word("丽"), new Word("医"), new Word("辰"), new Word("励"), new Word("否"), new Word("还"), new Word("歼"), new Word("来"), new Word("连"), new Word("步"), new Word("坚"), new Word("旱"), new Word("盯"), new Word("呈"), new Word("时"), new Word("吴"), new Word("助"), new Word("县"), new Word("里"), new Word("呆"), new Word("旷"), new Word("围"), new Word("呀"), new Word("吨"), new Word("足"), new Word("邮"), new Word("男"), new Word("困"), new Word("吵"), new Word("串"), new Word("员"), new Word("听"), new Word("吩"), new Word("吹"), new Word("呜"), new Word("吧"), new Word("吼"), new Word("别"), new Word("岗"), new Word("帐"), new Word("财"), new Word("针"), new Word("钉"), new Word("告"), new Word("我"), new Word("乱"), new Word("利"), new Word("秃"), new Word("秀"), new Word("私"), new Word("每"), new Word("兵"), new Word("估"), new Word("体"), new Word("何"), new Word("但"), new Word("伸"), new Word("作"), new Word("伯"), new Word("伶"), new Word("佣"), new Word("低"), new Word("你"), new Word("住"), new Word("位"), new Word("伴"), new Word("身"), new Word("皂"), new Word("佛"), new Word("近"), new Word("彻"), new Word("役"), new Word("返"), new Word("余"), new Word("希"), new Word("坐"), new Word("谷"), new Word("妥"), new Word("含"), new Word("邻"), new Word("岔"), new Word("肝"), new Word("肚"), new Word("肠"), new Word("龟"), new Word("免"), new Word("狂"), new Word("犹"), new Word("角"), new Word("删"), new Word("条"), new Word("卵"), new Word("岛"), new Word("迎"), new Word("饭"), new Word("饮"), new Word("系"), new Word("言"), new Word("冻"), new Word("状"), new Word("况"), new Word("床"), new Word("库"), new Word("疗"), new Word("应"), new Word("冷"), new Word("这"), new Word("序"), new Word("辛"), new Word("弃"), new Word("冶"), new Word("忘"), new Word("闲"), new Word("间"), new Word("闷"), new Word("灶"), new Word("灿"), new Word("弟"), new Word("汪"), new Word("沙"), new Word("汽"), new Word("沃"), new Word("泛"), new Word("沟"), new Word("没"), new Word("沈"), new Word("沉"), new Word("怀"), new Word("忧"), new Word("快"), new Word("完"), new Word("宋"), new Word("宏"), new Word("牢"), new Word("究"), new Word("穷"), new Word("灾"), new Word("良"), new Word("证"), new Word("启"), new Word("评"), new Word("补"), new Word("初"), new Word("社"), new Word("识"), new Word("诉"), new Word("词"), new Word("译"), new Word("君"), new Word("灵"), new Word("即"), new Word("层"), new Word("尿"), new Word("尾"), new Word("迟"), new Word("局"), new Word("改"), new Word("张"), new Word("忌"), new Word("际"), new Word("陆"), new Word("阿"), new Word("陈"), new Word("阻"), new Word("附"), new Word("妙"), new Word("妖"), new Word("妨"), new Word("努"), new Word("忍"), new Word("劲"), new Word("鸡"), new Word("驱"), new Word("纯"), new Word("纱"), new Word("纵"), new Word("纷"), new Word("纸"), new Word("纹"), new Word("纺"), new Word("奉"), new Word("玩"), new Word("环"), new Word("武"), new Word("青"), new Word("责"), new Word("现"), new Word("表"), new Word("规"), new Word("抹"), new Word("拢"), new Word("拔"), new Word("拣"), new Word("担"), new Word("抽"), new Word("拐"), new Word("拖"), new Word("拍"), new Word("者"), new Word("顶"), new Word("拆"), new Word("拥"), new Word("抵"), new Word("拘"), new Word("势"), new Word("抱"), new Word("垃"), new Word("拉"), new Word("拦"), new Word("幸"), new Word("招"), new Word("坡"), new Word("披"), new Word("拨"), new Word("择"), new Word("抬"), new Word("其"), new Word("取"), new Word("苦"), new Word("若"), new Word("茂"), new Word("苹"), new Word("苗"), new Word("英"), new Word("直"), new Word("茄"), new Word("茎"), new Word("茅"), new Word("林"), new Word("枝"), new Word("杯"), new Word("柜"), new Word("析"), new Word("板"), new Word("松"), new Word("枪"), new Word("构"), new Word("杰"), new Word("述"), new Word("枕"), new Word("丧"), new Word("或"), new Word("画"), new Word("卧"), new Word("事"), new Word("刺"), new Word("枣"), new Word("雨"), new Word("卖"), new Word("矿"), new Word("码"), new Word("厕"), new Word("奔"), new Word("奇"), new Word("奋"), new Word("态"), new Word("垄"), new Word("妻"), new Word("轰"), new Word("顷"), new Word("转"), new Word("斩"), new Word("轮"), new Word("软"), new Word("到"), new Word("非"), new Word("叔"), new Word("肯"), new Word("齿"), new Word("些"), new Word("虎"), new Word("虏"), new Word("贤"), new Word("尚"), new Word("旺"), new Word("具"), new Word("果"), new Word("味"), new Word("昆"), new Word("国"), new Word("昌"), new Word("畅"), new Word("明"), new Word("易"), new Word("昂"), new Word("典"), new Word("固"), new Word("咐"), new Word("呼"), new Word("鸣"), new Word("咏"), new Word("呢"), new Word("岸"), new Word("岩"), new Word("帖"), new Word("罗"), new Word("帜"), new Word("岭"), new Word("凯"), new Word("败"), new Word("贩"), new Word("购"), new Word("图"), new Word("钓"), new Word("制"), new Word("知"), new Word("垂"), new Word("牧"), new Word("物"), new Word("乖"), new Word("刮"), new Word("秆"), new Word("和"), new Word("季"), new Word("委"), new Word("佳"), new Word("侍"), new Word("供"), new Word("使"), new Word("例"), new Word("版"), new Word("侄"), new Word("侦"), new Word("侧"), new Word("凭"), new Word("侨"), new Word("佩"), new Word("货"), new Word("依"), new Word("的"), new Word("迫"), new Word("质"), new Word("欣"), new Word("征"), new Word("往"), new Word("爬"), new Word("彼"), new Word("径"), new Word("所"), new Word("舍"), new Word("金"), new Word("命"), new Word("斧"), new Word("爸"), new Word("采"), new Word("受"), new Word("乳"), new Word("贪"), new Word("肤"), new Word("肺"), new Word("肢"), new Word("肿"), new Word("胀"), new Word("朋"), new Word("股"), new Word("肥"), new Word("服"), new Word("胁"), new Word("周"), new Word("昏"), new Word("鱼"), new Word("兔"), new Word("忽"), new Word("狗"), new Word("备"), new Word("饰"), new Word("饱"), new Word("饲"), new Word("变"), new Word("京"), new Word("享"), new Word("店"), new Word("夜"), new Word("庙"), new Word("府"), new Word("底"), new Word("剂"), new Word("废"), new Word("净"), new Word("盲"), new Word("放"), new Word("刻"), new Word("育"), new Word("闸"), new Word("闹"), new Word("郑"), new Word("券"), new Word("卷"), new Word("单"), new Word("炒"), new Word("沫"), new Word("浅"), new Word("法"), new Word("泄"), new Word("河"), new Word("沾"), new Word("泪"), new Word("油"), new Word("泊"), new Word("沿"), new Word("泡"), new Word("注"), new Word("泻"), new Word("泳"), new Word("泥"), new Word("沸"), new Word("波"), new Word("泼"), new Word("泽"), new Word("治"), new Word("怖"), new Word("性"), new Word("怕"), new Word("怜"), new Word("怪"), new Word("学"), new Word("宝"), new Word("宗"), new Word("定"), new Word("宜"), new Word("审"), new Word("宙"), new Word("官"), new Word("空"), new Word("帘"), new Word("实"), new Word("试"), new Word("郎"), new Word("诗"), new Word("肩"), new Word("房"), new Word("诚"), new Word("衬") };
    public int RandKey=0;

    public static int Hard=5;
    public int Chance = 3;          //生命
    public GameObject[] ChanceShow;

    public int AllBase = 0;
 
    public GameObject OkButtom;

    public Transform GridParent;           //格子类的父组件
    public Dictionary<int, int> GridConfig = new Dictionary<int, int>() { { 4, 172 }, { 5, 138 }, { 6, 115 } ,{7 ,99},{ 8 , 87},{ 9 , 77},{ 10,70} };

   
    public GameObject GridPrefab;
    private int row, col;

    public GameObject GiveupBottom;         

    public GameObject ZJbar;            //遮盖用竹简

    public GameObject FailText;
    public Text FailTextScore;
   
    void Start()
    {
        GrobalClass.GrobalClassInit();

        GetNewWord();
        ZJbar.GetComponent<Animator>().CrossFade("盖住后向右", 1f);
        
    }

    void Update()
    { 
      
    }

    public void OkClick()
    {
        
        if (Answer.text == NeedAnswerWord.text)
        {
            foreach (Transform child in GridParent)     //清空画布内所有子对象(格子)
            {
                Destroy(child.gameObject);
            }
            Hard = 4;
           
            Msg.text = "道字正确";
            GrobalClass.IScore = GrobalClass.IScore + GrobalClass.Steps*2+2;                                            //加分,剩余步数*2+基础分2为一局分数
            Score.text = "分数:" + GrobalClass.IScore;
           
           
            OkButtom.SetActive(false);                      //整个按钮部件(包括内部文本一类的内容)取消启用

            WordBase[RandKey].IfBeChoose = true;            //把该字类的成员开关打开，以后函数在字库里挑字会跳过这些打开的开关防止重复

            Invoke("GetNewWord", 1.4f);                        //两秒后执行该函数

        }
        else {
            Msg.text = "道字错误";
            Chance--;

            for (int I = 0; I < 3; I++)
            {
                ChanceShow[I].SetActive(false);
            }
            for (int I=0;I<Chance;I++)
            {
                ChanceShow[I].SetActive(true);
            }
            if(Chance<=0)
            {
                RealFail();    //三次警告失败，强制传唤
            }
        }
        Answer.text = "";               //清空输入框
    }

    public bool GetNewWord()
    {
        GiveupBottom.SetActive(true);  //有可能是点击失败按钮后来获取的下一关，不管怎样都激活一次
       
        AllBase++;
        if (AllBase > WordBase.Length)
        {
            RandKey = 0;
            Msg.text = "题库用完力，属实牛逼嗷";
            return false;
        }
    
        InitGrid();
        Msg.text = "该字为";
        OkButtom.SetActive(true);
        do
        {
            RandKey = Random.Range(1, WordBase.Length);
         
        } while (WordBase[RandKey].IfBeChoose != false);

        NeedAnswerWord.text = WordBase[RandKey].Data;

        return true;                //成功修改

    }

    public void Quit()                  //退出游戏
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void InitGrid()
    {

        GrobalClass.Steps = 0;                                               //重置已有步数
        if (AllBase < 70) {
            Hard = 4 + AllBase / 10;                        //难度(网格)增加
            GrobalClass.NextSteps = 6 + AllBase / 5;        //提供的步数增加
        }
        else
        {
            Hard = 10;                      //达到最大难度就强制为这个设置
            GrobalClass.NextSteps = 16;
        }
        GrobalClass.ChangeSteps(GrobalClass.NextSteps);         //步数正式赋值
        TStep.GetComponent<Text>().text = "剩余步数:" + GrobalClass.Steps;

        int GridNum = PlayerPrefs.GetInt("5", Hard);                                    //判定是否为临界点(整十关),过了加一层网格，大于10始终按10的来

        Level.text = "第" + AllBase + "字";
      
        GridLayoutGroup GridGroup = GridParent.GetComponent<GridLayoutGroup>();
        GridGroup.constraintCount = GridNum;
        GridGroup.cellSize = new Vector2(GridConfig[GridNum], GridConfig[GridNum]);
        row = GridNum;
        col = GridNum;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                CreateGrid();
            }
        }
    }

    public void CreateGrid()
    {
        GameObject gameObject = GameObject.Instantiate(GridPrefab, GridParent);
    }
   
    public void GiveupClick()                                   //按钮放弃被点击
    {

        Chance--;
        for (int I = 0; I < 3; I++)
        {
            ChanceShow[I].SetActive(false);
        }
        for (int I = 0; I < Chance; I++)
        {
            ChanceShow[I].SetActive(true);
        }
        if (Chance <= 0)
        {
            RealFail();    //三次警告失败，强制传唤
        }
        else
        {
            foreach (Transform child in GridParent)     //清空画布内所有子对象(格子)
            {
                Destroy(child.gameObject);
            }
            OkButtom.SetActive(false);          //禁用提交答案按钮
            GiveupBottom.SetActive(false);

            Msg.text = "放弃本轮";
            OkButtom.SetActive(false);                      //整个按钮部件(包括内部文本一类的内容)取消启用

            Invoke("GetNewWord", 1.4f);                        //两秒后执行该函数



        }

    }
    public void RealFail()
    {
        foreach (Transform child in GridParent)     //清空画布内所有子对象(格子)，显示几秒答案
        {
            child.GetComponent<Animator>().CrossFade("Presson", 1.0f); //播放逐渐缩小动画
        }
        OkButtom.SetActive(false);            //禁用提交答案按钮
        GiveupBottom.SetActive(false);


        Msg.text = "结束";

        OkButtom.SetActive(false);                      //整个按钮部件(包括内部文本一类的内容)取消启用
        StartCoroutine(ContinFail());

    }
    IEnumerator ContinFail()
    {
        yield return new WaitForSeconds(2.0f);          //挂机几秒
        ZJbar.GetComponent<Animator>().CrossFade("左横盖住", 2f);       //播放动画
        FailText.GetComponent<Animator>().CrossFade("下落回弹", 1f);
        FailTextScore.text = "*" + GrobalClass.IScore + "*";

    }
}


