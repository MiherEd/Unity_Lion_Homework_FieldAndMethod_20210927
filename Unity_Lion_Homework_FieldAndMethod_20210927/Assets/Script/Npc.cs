using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
     /// <summary>
     /// ��ܥ\��
     /// </summary>
     /// <param name="dialogue">NPC ����ܤ��e</param>
    private void Dialogue(string dialogue)
    {

    }
    /// <summary>
    /// ��s����
    /// </summary>
    /// <param name="propMission">���ȹD��ƶq</param>
    /// <returns></returns>
    private int UpdateMission(int propMission = 1)
    {
        return 0;
    }
    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="indexMission">���Ƚs��</param>
    /// <returns></returns>
    private bool MissionFinish(int indexMission)
    {
        return false;
    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public int BuyProp(int price = 100)
    {
        return 0;
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="indexMission"></param>
    public void GetMission(int indexMission)
    {

    }
}
