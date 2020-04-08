using UnityEngine;

// 雙斜線 註解，可用在說明或是紀錄上，只會在腳本內看到
// summary 摘要。描述此內容，會在其他腳本內看到

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
    // 資料類型 欄位名稱 = 指定值;
    // 欄位名稱如果用到保留字顏色會變
    // 請注意欄位名稱不要使用數字開頭或是保留字
    // 預設值： int‧float 為 0
    // string 為 ""
    // bool 為 false
   
    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW"; 
    bool brake = false;
}
