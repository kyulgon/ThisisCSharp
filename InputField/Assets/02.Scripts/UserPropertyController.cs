using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class UserPropertyController : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private User m_user = null;

    [Header("Controller")]
    [SerializeField] private InputField m_idInputField = null;
    [SerializeField] private InputField m_nameInputField = null;
    [SerializeField] private InputField m_phoneNumberInputField = null;
    [SerializeField] private InputField m_positionXInputField = null;
    [SerializeField] private InputField m_positionYInputField = null;
    [SerializeField] private InputField m_positionZInputField = null;
    [SerializeField] private InputField m_rotationXInputField = null;
    [SerializeField] private InputField m_rotationYInputField = null;
    [SerializeField] private InputField m_rotationZInputField = null;

    void Awake()
    {
        m_phoneNumberInputField.onEndEdit.AddListener(OnPhoneNumberChanged);
    }

    public void OnIDChanged(string text)
    {
        if (uint.TryParse(text, out var value))
            m_user.ID = value;
        m_idInputField.text = m_user.ID.ToString();
    }

    public void OnNameChanged(string text)
    {
        m_user.Name = text;
    }

    public void OnPhoneNumberChanged(string text)
    {
        m_user.PhoneNumber = text;
    }

    public void OnPositionXChanged(string text)
    {
        var position = m_user.Position;
        position.x = float.Parse(text);
        m_user.Position = position;
        m_positionXInputField.text = m_user.Position.x.ToString();
    }
}
