using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class UserPropertyController_Gon : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private User_Gon m_user = null;

    [Header("Controller")]
    [SerializeField] private InputField m_idInputField = null;
    [SerializeField] private InputField m_nameInputField = null;
    [SerializeField] private InputField m_phoneNumInputField = null;
    [SerializeField] private InputField m_positionXInputField = null;
    [SerializeField] private InputField m_positionYInputField = null;
    [SerializeField] private InputField m_positionZInputField = null;
    [SerializeField] private InputField m_rotationXInputField = null;
    [SerializeField] private InputField m_rotationYInputField = null;
    [SerializeField] private InputField m_rotationZInputField = null;
    [SerializeField] private InputField m_deleteInputField = null;
    [SerializeField] private InputField m_modifyInputField = null;

    [SerializeField] private UserObject userPrefabs; // cube 프리팹
    [SerializeField] private GameObject deleteImage; // 삭제를 위한 InputField 작성 객체
    [SerializeField] private GameObject modifyImage; // 수정을 위한 InputField 작성 객체

    public List<UserObject> userList = new List<UserObject>();
    
    private bool isDuplicateCheck = false;
    private bool isModifyImage = false;
    private bool isDeleteImage = false;
   

    public void OnMakeUser() // user 생성
    {
        if (isDuplicateCheck == true && m_idInputField.text != "" && m_nameInputField.text != "" && m_phoneNumInputField.text != "" &&
           m_positionXInputField.text != "" && m_positionYInputField.text != "" && m_positionZInputField.text != "" &&
        m_rotationXInputField.text != "" && m_rotationYInputField.text != "" && m_rotationZInputField.text != "")
        {
            UserObject userObject = Instantiate(userPrefabs, m_user.Position, Quaternion.Euler(m_user.Rotation));
            userObject.transform.parent = gameObject.transform;
            userObject.name = m_user.Name;
            userObject.ID = uint.Parse(m_idInputField.text);
            userObject.Name = m_nameInputField.text;

            var phone1 = m_phoneNumInputField.text.Substring(0, 3);
            var phone2 = m_phoneNumInputField.text.Substring(3, 4);
            var phone3 = m_phoneNumInputField.text.Substring(7, 4);
            var phone_total = phone1 + "-" + phone2 + "-" + phone3;
            userObject.PhoneNumber = phone_total;

            userList.Add(userObject);

            m_idInputField.text = null;
            m_nameInputField.text = null;
            m_phoneNumInputField.text = null;
            m_positionXInputField.text = null;
            m_positionYInputField.text = null;
            m_positionZInputField.text = null;
            m_rotationXInputField.text = null;
            m_rotationYInputField.text = null;
            m_rotationZInputField.text = null;
            
        }
        else if(m_idInputField.text != "" && m_nameInputField.text != "" && m_phoneNumInputField.text != "" &&
           m_positionXInputField.text != "" && m_positionYInputField.text != "" && m_positionZInputField.text != "" &&
        m_rotationXInputField.text != "" && m_rotationYInputField.text != "" && m_rotationZInputField.text != "")
        {
            Debug.Log("중복체크를 눌러주세요.");
        }
        else
        {
            Debug.Log("빈칸을 채워주세요.");
        }
       


        // 정규화로 만드는 방법 다시 공부
        //Regex regex = new Regex(@"010-[0-9]{4}-[0-9]{4}");
        //MatchCollection mc = regex.Matches(userObject.PhoneNumber);

        //foreach (Match m in mc)
        //{
        //    for (int i = 0; i < m.Groups.Count; i++)
        //    {
        //        Group g = m.Groups[i];
        //        Debug.Log($"{userObject.PhoneNumber}");
        //    }
        //}
    }

    public void DuplicateCheck() //중복체크 → 존재할때만 보여줌
    {        
        if(userList.Count != 0)
        {
            for (int i = 0; i < userList.Count; ++i)// 생성된 user를 전부 검사
            {
                if (userList[i].ID == uint.Parse(m_idInputField.text))  // 생성되어져 있는 user와 현재 inputfield에 작성한 값이 같은지 확인
                {
                    Debug.Log("이미 존재하는 ID 입니다.");
                }
            }
            for (int i = 0; i < userList.Count; ++i)// 생성된 user를 전부 검사
            {
                if (userList[i].ID != uint.Parse(m_idInputField.text))  // 생성되어져 있는 user와 현재 inputfield에 작성한 값이 같은지 확인
                {
                    Debug.Log("사용 가능한 ID 입니다.");
                    isDuplicateCheck = true;
                }
            }
        }
        else
        {
            Debug.Log("사용 가능한 ID 입니다.");
            isDuplicateCheck = true;
        }
        
    }


    public void ModifyBtn()  // 수정버튼
    {
        if (userList.Count != 0)
        {
            if (isModifyImage == true) // 수정ID Image 켜기
            {
                modifyImage.SetActive(true);
                isModifyImage = false;
            }
            else// 수정ID Image 끄기
            {
                modifyImage.SetActive(false);
                isModifyImage = true;
            }

            for (int i = 0; i < userList.Count; i++) // 수정할 아이디 찾기
            {
                //if (userList[i].ID == uint.Parse(m_modifyInputField.text)) 

                // var modi = uint.TryParse(m_modifyInputField.text, out var value);
                
                if (userList[i].ID == uint.Parse(m_modifyInputField.text)) 
                {
                    // 불러와서 inputfield값을 다시 저장


                    //// 삭제하고 다시 생성
                    //Destroy(userList[i].gameObject);
                    //userList.RemoveAt(i);
                    //OnMakeUser();
                }
            }
            m_modifyInputField.text = "";
        }
        else
        {
            Debug.Log("수정할 User가 존재하지 않습니다.");
        }       
    }



    public void DeleteBtn() // ID 삭제버튼
    {
        if (userList.Count != 0)
        {
            if (isDeleteImage == true) // 수정ID Image 켜기
            {
                deleteImage.SetActive(true);
                isDeleteImage = false;
            }
            else// 수정ID Image 끄기
            {
                deleteImage.SetActive(false);
                isDeleteImage = true;
            }

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].ID == uint.Parse(m_deleteInputField.text))
                {
                    Destroy(userList[i].gameObject);
                    userList.RemoveAt(i);
                    deleteImage.SetActive(false);
                }
            }
            m_deleteInputField.text = "";
        }
        else
        {
            Debug.Log("삭제할 User가 존재하지 않습니다.");
        }

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

    public void OnPositionYChanged(string text)
    {
        var position = m_user.Position;
        position.y = float.Parse(text);
        m_user.Position = position;
        m_positionYInputField.text = m_user.Position.y.ToString();
    }

    public void OnPositionZChanged(string text)
    {
        var positon = m_user.Position;
        positon.z = float.Parse(text);
        m_user.Position = positon;
        m_positionZInputField.text = m_user.Position.z.ToString();
    }

    public void OnRotationXChanged(string text)
    {
        var rotation = m_user.Rotation;
        rotation.x = float.Parse(text);
        m_user.Rotation = rotation;
        m_rotationXInputField.text = m_user.Rotation.x.ToString();
    }

    public void OnRotationYChanged(string text)
    {
        var rotation = m_user.Rotation;
        rotation.y = float.Parse(text);
        m_user.Rotation = rotation;
        m_rotationYInputField.text = m_user.Rotation.y.ToString();
    }

    public void OnRotationZChanged(string text)
    {
        var rotation = m_user.Rotation;
        rotation.z = float.Parse(text);
        m_user.Rotation = rotation;
        m_rotationZInputField.text = m_user.Rotation.z.ToString();
    }

   
}
