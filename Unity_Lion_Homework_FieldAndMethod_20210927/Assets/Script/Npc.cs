using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
     /// <summary>
     /// 對話功能
     /// </summary>
     /// <param name="dialogue">NPC 的對話內容</param>
    private void Dialogue(string dialogue)
    {

    }
    /// <summary>
    /// 更新任務
    /// </summary>
    /// <param name="propMission">任務道具數量</param>
    /// <returns></returns>
    private int UpdateMission(int propMission = 1)
    {
        return 0;
    }
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="indexMission">任務編號</param>
    /// <returns></returns>
    private bool MissionFinish(int indexMission)
    {
        return false;
    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public int BuyProp(int price = 100)
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="indexMission"></param>
    public void GetMission(int indexMission)
    {

    }
}
