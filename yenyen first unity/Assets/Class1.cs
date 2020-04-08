using UnityEngine;    // 引用 Unity提供的API(函式庫:Unity功能與屬性) . 2020年4月8日學習

// 類別 class 定義一個物件
// 語法：class 類別名稱
// ：Monobehaviour 可以將此腳本掛在Unity 物件上
public class Class1 : MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1.大小不一樣
    // 2.括號成對出現() [] {} '' "" < >

    // 事件：在特定時間會以指定次數執行的方法 ex:遊戲開始的時候執行OP、TITLE動畫LOOP等 (名稱為藍色)
    // 開始事件：播放遊戲時執行一次 - ex:指定初始設定，如剛開始的所持金等
    private void Start()
    {
        // 輸出("文字訊息");
        // C# 結尾為分號;
        print("hello world");
    }
}
