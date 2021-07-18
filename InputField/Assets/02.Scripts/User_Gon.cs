using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class User_Gon // 데이터를 저장할 곳
{
    // 프로퍼티에 읽고 쓸 변수를 생성
    [SerializeField] private uint m_id = 0;
    [SerializeField] private string m_name = "";
    [SerializeField] private string m_phoneNum = "";
    [SerializeField] private Vector3 m_position = Vector3.zero;
    [SerializeField] private Vector3 m_rotation = Vector3.zero;


    // 프로퍼티 생성
    public uint ID
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

    public string Name
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

    public string PhoneNumber
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

    public Vector3 Position
    {
        get
        {
            return m_position;
        }
        set
        {
            m_position = value;
        }
    }

    public Vector3 Rotation
    {
        get
        {
            return m_rotation;
        }
        set
        {
            m_rotation = value;
        }
    }

    public User_Gon(uint id)
    {
        m_id = id;
    }
}
