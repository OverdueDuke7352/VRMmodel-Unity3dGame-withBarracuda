using UnityEngine;
using System.Collections;

/// <summary>
/// 功能：修改游戏FPS
/// </summary>
public class UpdateFrame : MonoBehaviour
{
    //游戏的FPS，可在属性窗口中修改
    public int targetFrameRate = 120;

    //当程序唤醒时
    void Awake()
    {
        //修改当前的FPS
        Application.targetFrameRate = targetFrameRate;
    }

}