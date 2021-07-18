using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User
{
    [SerializeField] private uint m_id = 0;
    [SerializeField] private string m_name = string.Empty;
    [SerializeField] private string m_phoneNumber = string.Empty;
    [SerializeField] private Vector3 m_position = Vector3.zero;
    [SerializeField] private Vector3 m_rotation = Vector3.zero;

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
            return m_phoneNumber;
        }
        set
        {
            m_phoneNumber = value;
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
}
