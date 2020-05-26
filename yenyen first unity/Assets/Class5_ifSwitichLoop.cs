using UnityEngine;

public class Class5_ifSwitichLoop : MonoBehaviour
{
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量"), Range(0, 100)]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;

    private int i = 1;
    private int j = 1;

    //Game Object 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };

    private void CreateFloor(int length, int width)
    {
        //巢狀迴圈
        //注意初始值名稱不能相同

        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API 實例化(生成)
                //生成(物件,座標,角度)
                //Vector3 三維向量(保存三個浮點數)
                //Quaternion角度 x,y,z,w
                //Quaternion.Identity零角度
                //Quaternion.Euler(x,y,z) 歐拉角度 - 0~360度
                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    private void Awake()
    {

        /*多行註解
        for (int i = 0; i < 101; i++)
        {
            print("break迴圈：" + i);
            //如果i等於10就打斷迴圈並且執行迴圈下方的程式
            if (i == 10) break;
        }
        print("break 迴圈外的程式");
       }*/

        /* for(int i = 0; i<101; i++)
         {
             print("return 迴圈：" + i);
             //如果1等於10就跳出方法外，下方的程式皆不執行
             if (i == 10) return;
         }

         print("return 迴圈外的程式");*/


        /* for (int i=0; i <20; i++)
         {
             if (i == 5) continue;
             print("continue迴圈" + i);

         }
         print("迴圈外的程式");*/


        for (int i = 0; i < 10; i++)
        {   
            //goto 標記名稱
            if (i == 5) goto Test;
            print("goto 迴圈：" + i);
        }
    //標記名稱：
    Test:
        //標記陳述式
        print("這是標記陳述式");


      //使用for迴圈取得陣列資料
       for(int i =0; i < scores.Length; i++)
      {
          print("for迴圈取得資料：" + scores[i]); 
      }

       //foreach迴圈
       //語法：foreach (取得資料的類型 取得資料的名稱 in 陣列) (執行次數為陣列數量)

        foreach (int item in scores)
        {
            print("foreach 迴圈取得資料：" + item);
        }

    #region    

        CreateFloor(30,5);

        //while迴圈
        //while (布林值) {當布林值為true執行}
        //迴圈之前評估 第一次判斷： j=1
        while(i<=10)
        {
            print("while 迴圈第：" + i + "次");
            i++;
        }
        //迴圈之後評估 第一次判斷： j=2
        do
        {
            print("do 迴圈第：" + j + "次");
            j++;
        }
        while (j <= 10);

        //for (初始值;條件;迭代器)
        for (int k = 1; k <= 10; k++)
        {
            print("for迴圈第：" + k + "次");
        }

        for(int k =10; k> 0; k--)
        {
            print("for迴圈第：" + k + "次");
        }


    }

#endregion



    // Start is called before the first frame update
    void Start()
    {
        //if判斷式
        //if(布林值) ( 布林值 = true時執行 )
        /*if(true)
         {
             print("HEY LISTEN~!");
         }*/

    }
    private void Update()
    {
        //當道具數量 >=5 任務完成 true
        complete = (count >= 5) ? true : false;
        test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當";
       

        /*利用判斷式 if的寫法
        if (count>=5)
        { complete=true; }
        else
        { complete=false;}
        */

        switch(prop)
        {
            case "紅水":
            print("補血");
            break;
            case "藍水":
            print("補MP");
            break;
            case "黃水":
            print("補EXP");
            break;
            default:
            print("哩家母丟藥啊~");
            break;
        }
        switch (season)
        {
            case Season.Spring:
                print("春天打老虎");
                break;
            case Season.Summer:
                print("夏天打老虎");
                break;
            case Season.Fall:
                print("秋天打老虎");
                break;
            case Season.Winter:
                print("冬天打老虎");
                break;
        }
        if(hp >=70)
        {
            print("安全");
        }
        else if(hp>=20)
        {
            print("警告");
        }
        else 
        {
            print("危險");
        }   
    }
    #region
    // 更新事件：一秒執行約60次(60FPS)
    /*private void Update()
    {
        // 當opendoor 為 true 執行(開門)
        // 當opendoor 為 false 執行(關門)
        // if (openDoor == true)
        if (openDoor)
        {
            print("開門~!");
        }
        else
        {
            print("關門~!");
        }

        //大於60及格
        //小於60不及格
        if (score >= 60)
        {
            print("及格!");
        }
        else if (score >= 40)
        {
            print("補考!");
        }
        else if (score >= 20)
        {
            print("付錢補考!");
        }
        else
        {
            print("被當!");
        }
           
    }*/
    #endregion


}
