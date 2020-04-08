using UnityEngine; // 引用Unity提供的API

/// <summary>
/// 定義機車物件
/// </summary>

public class Motorbike : MonoBehaviour
{
    /// <summary>
    /// 機車c.c數
    /// </summary>
    [Header("機車的c.c數"), Tooltip("機車的c.c.數，影響到機車馬力"), Range(100, 250)]
    public int cc = 150;

    [Header("機車的重量"), Tooltip("機車的重量，影響到機車的基礎速度"), Range(30, 80)]
    public float Weight = 50;
    
   // [Header("機車的廠牌"), Tooltip("機車的廠牌，有其他參數補正")]
   // public string = ""
}
