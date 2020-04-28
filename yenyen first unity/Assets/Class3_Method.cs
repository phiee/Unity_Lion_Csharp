using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    // 預置物: prefabs

    public Person person1;
    public Person person2;
    public Person person3;

    private void Start()
    {
        // 呼叫person1 方法 Talk
        person1.Talk();
        person2.Talk();
        person3.Talk1();

        // 傳回方法可以直接當作傳回類型使用
        print("屁孩 BMI" + person1.BMI());
        print("警察杯杯 BMI" + person2.BMI());
        print("消波塊 BMI" + person3.BMI());

        // 使用有參數的方法必須填入對應的引數
        // 指定選填式參數 【選填式參數名稱：值】
        person1.Walk(99, sound:"嘎嘎嘎");
        person2.Walk10();
        person3.Walk(20,"左邊",shoes:"布鞋");

        person1.Attack();
        person2.Attack("空氣槍");
        person3.Attack("牙齒");
    }

}

