using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserObject : MonoBehaviour
{
    [SerializeField] private User_Gon m_data = null;

    public User_Gon Data => m_data;

    public void Bind(User_Gon data)
    {
        m_data = data;
        OnPropertyChanged();
    }

    public void OnPropertyChanged()
    {
        var data = Data;
        if (data != null)
        {
            this.name = data.Name;
            this.transform.position = data.Position;
            this.transform.rotation = Quaternion.Euler(data.Rotation);
        }
    }
}
