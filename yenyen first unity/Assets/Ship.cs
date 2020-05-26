using UnityEngine;

public class Ship : MonoBehaviour
{
    // 公開欄位：給任何人存取
    // 從其他類別取得或存放資料
    public float speed = 20;

    // 私人欄位：僅限於此類別存取 
    // 從其他類別無法取得或存放資料
    private float weight = 50;


    //問題：
    //假設需要取得但是不能修改 - 屬性 (權限)
    //屬性語法
    //修飾詞 類型 名稱 { 存取權限 }
    //get 可以取得
    //set可以存放
    //讀寫權限屬性
    //屬性不會顯示在屬性面板上 (ODIN) - UNITYEDITOR
    public float length { get; set; }

    //企劃：寬度固定30不變
    //用屬性來作封裝欄位：
    //1.有私人欄位 2.有唯讀屬性 (return 私人欄位)
    //這筆資料無法從外面作修改，適合用在多人開發、大型專案時
    //用來保護自己的資料
        private float _width = 30;

    //唯讀屬性：不能設定值，預設值就是0
    public float width { get { return _width; } }

    // 企劃：高度固定10.5不變
    private float _height =10.5f;

    // => (黏巴達 Lambda)
    // C# 6 版以上 | Unity 2017 C# 7 版
    // C# 會持續作改版，目前最新是 8 版
    // get => _height; 等同於 get
    //唯讀屬性
    public float height { get => _height; }

    private float lv = 3;

    // 封裝欄位：
    // 1.私人欄位
    // 2.透過屬性存取 (return 私人欄位) {私人欄位 = value}
    private float _atk;
    public float atk { get { return _atk; } set { _atk = value * lv; } }

    // 使用快速完成的黏巴達寫法 50行與54行相同 只是版本不同
    private float _def;
    public float def { get => _def; set => _def = value * lv; }

    #region 自己練習用的
    //private float _luk;
    //Lambda public float Luk { get => _luk; set => _luk = value * lv; }
    //舊版本 public float Luk { get { return _luk; } set { _luk = value * lv; } }
    #endregion


}
