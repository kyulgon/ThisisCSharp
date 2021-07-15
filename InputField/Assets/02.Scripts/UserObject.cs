using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserObject : MonoBehaviour
{
    [SerializeField] private uint m_id = 0;
    [SerializeField] private string m_name = string.Empty;
    [SerializeField] private string m_phoneNum = string.Empty;


    public uint ID // cube에 id값을 넣어주기 위해
    {
        get
        {
            return m_id;
        }
        set
        {
            m_id = value;
        }
    }

    public string Name // cube에 id값을 넣어주기 위해
    {
        get
        {
            return m_name;
        }
        set
        {
            m_name = value;
        }
    }

    public string PhoneNumber // cube에 id값을 넣어주기 위해
    {
        get
        {
            return m_phoneNum;
        }
        set
        {
            m_phoneNum = value;
        }
    }
}
