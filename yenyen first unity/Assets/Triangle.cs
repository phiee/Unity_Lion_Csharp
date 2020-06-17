using UnityEngine;

/// <summary>
/// 三角形 繼承 形狀
/// 三角形體積需要複寫
/// </summary>

public class Triangle : Shape
{

    /// <summary>
    /// override 複寫：複寫類別
    /// </summary>
    /// <returns></returns>
    public override float GetVolume()
    {
        volume = length * width * height / 2; //三角形體積
        return volume;
    }

    private void Start()
    {
        print(gameObject + "體積：" + GetVolume());
    } 
}
