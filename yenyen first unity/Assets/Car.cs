using UnityEngine;

// 雙斜線 註解，可用在說明或是紀錄上，只會在腳本內看到
// summary 摘要。描述此內容，會在其他腳本內看到 - 提高辨識性、維護性與可讀性
// 新增的 C# 放在專案內為藍圖
// 放在場景物件上才會是實體物件

/// <summary>
///定義汽車物件
/// </summary>

public class Car : MonoBehaviour
{
    // 認識第一個成員： 欄位 field -儲存物件資料
    // 資料類型
    // c.c.數   - 2000      整數    int    
    // 重量     - 100.9     浮點數  float  - C#中只要用到浮點數，後面一定要加f(或是F)
    // 品牌     - BMW       文字    string 
    // 剎車     - 是否開啟  布林值  bool   - true/false

    // 定義欄位語法：
    // 修飾詞 資料類型 欄位名稱 = 指定值;

    // 修飾詞：
    // 公開 public ：允許其他類別存取‧顯示在屬性面板(inspecter)
    // 私人 private：不允許其他類別存取‧不顯示在屬性面板(inspecter)
    // 欄位名稱如果用到保留字顏色會變
    // 請注意欄位名稱不要使用數字開頭或是保留字

    // 預設值： int‧float 為 0
    // string 為 ""
    // bool 為 false

    // 欄位屬性 Attribute：Unity 提供用於輔助欄位的功能
    // 語法：[屬性名稱(值)]
    // 標題 [Header("字串")]
    // 提示 [Tooltip("字串")]
    // 範圍 [Range(最小值,最大值)]

    /// <summary>
    /// 汽車的C.C.數
    /// </summary>
    [Header("汽車的C.C.數"),Tooltip("本車的c.c.數，作為汽車的馬力基準"),Range(500,5000)]
    public int cc = 2000;

    /// <summary>
    /// 汽車的重量
    /// </summary>
    [Header("汽車的重量"),Tooltip("本車的重量，作為汽車的速度基準"),Range(80,300)]
    public float weight = 100.9f;

    /// <summary>
    /// 汽車的廠牌
    /// </summary>
    [Header("汽車的廠牌"),Tooltip("本車的廠牌，作為汽車的額外加成基準")]
    public string brand = "BMW";

    /// <summary>
    /// 汽車的剎車狀態
    /// </summary>
    [Header("汽車的剎車狀態"),Tooltip("初始皆為false狀態，為未踩剎車的狀況")]
    public bool brake = false;

}
