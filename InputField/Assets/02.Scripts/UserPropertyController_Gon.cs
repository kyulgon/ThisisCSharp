using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class UserPropertyController_Gon : MonoBehaviour
{
    [Header("Controller")]
    [SerializeField] private Dropdown m_userDropdown = null;
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

    public List<UserObject> userObjectList = new List<UserObject>();

    [Header("Selected")]
    [SerializeField] private UserObject m_selectedUserObject = null;

    private bool isDuplicateCheck = false;
    private bool isModifyImage = false;
    private bool isDeleteImage = false;
   
    void Awake()
    {
        Initialize();

        if (m_userDropdown != null) m_userDropdown.options.Clear();
    }

    public void OnMakeUser() // user 생성
    {
        if (string.IsNullOrEmpty(m_idInputField.text))
        {
            Debug.Log("ID를 입력해주세요");
            return;
        }

        var id = uint.Parse(m_idInputField.text);
        if (Exists(id) == false)
        {
            var user = new User_Gon(id);
            Apply(user);

            UserObject userObject = Instantiate(userPrefabs, user.Position, Quaternion.Euler(user.Rotation));
            userObject.transform.parent = gameObject.transform;
            userObject.Bind(user);
            userObjectList.Add(userObject);

            m_selectedUserObject = userObject;

            m_userDropdown.options.Add(new Dropdown.OptionData() { text = user.ID.ToString() });
            m_userDropdown.value = m_userDropdown.options.Count - 1;
            m_userDropdown.RefreshShownValue();

            UpdateUI(user);
        }
        else
        {
            Debug.Log("이미 존재하는 ID 입니다.");
        }


        //if (isDuplicateCheck == true && m_idInputField.text != "" && m_nameInputField.text != "" && m_phoneNumInputField.text != "" &&
        //   m_positionXInputField.text != "" && m_positionYInputField.text != "" && m_positionZInputField.text != "" &&
        //m_rotationXInputField.text != "" && m_rotationYInputField.text != "" && m_rotationZInputField.text != "")
        //{
        //    UserObject userObject = Instantiate(userPrefabs, m_user.Position, Quaternion.Euler(m_user.Rotation));
        //    userObject.transform.parent = gameObject.transform;
        //    userObject.name = m_user.Name;
        //    userObject.ID = uint.Parse(m_idInputField.text);
        //    userObject.Name = m_nameInputField.text;

        //    var phone1 = m_phoneNumInputField.text.Substring(0, 3);
        //    var phone2 = m_phoneNumInputField.text.Substring(3, 4);
        //    var phone3 = m_phoneNumInputField.text.Substring(7, 4);
        //    var phone_total = phone1 + "-" + phone2 + "-" + phone3;
        //    userObject.PhoneNumber = phone_total;

        //    userList.Add(userObject);

        //    m_userDropdown.options.Add(new Dropdown.OptionData() { text = userObject.ID.ToString() });
        //    m_userDropdown.value = m_userDropdown.options.Count - 1;
        //    m_userDropdown.RefreshShownValue();

        //    m_idInputField.text = userObject.ID.ToString();
        //    m_nameInputField.text = userObject.name;
        //    m_phoneNumInputField.text = userObject.PhoneNumber;
        //    m_positionXInputField.text = userObject.transform.position.x.ToString();
        //    m_positionYInputField.text = userObject.transform.position.y.ToString();
        //    m_positionZInputField.text = userObject.transform.position.z.ToString();
        //    m_rotationXInputField.text = userObject.transform.rotation.x.ToString();
        //    m_rotationYInputField.text = userObject.transform.rotation.y.ToString();
        //    m_rotationZInputField.text = userObject.transform.rotation.z.ToString();
        //}
        //else if(m_idInputField.text != "" && m_nameInputField.text != "" && m_phoneNumInputField.text != "" &&
        //   m_positionXInputField.text != "" && m_positionYInputField.text != "" && m_positionZInputField.text != "" &&
        //m_rotationXInputField.text != "" && m_rotationYInputField.text != "" && m_rotationZInputField.text != "")
        //{
        //    Debug.Log("중복체크를 눌러주세요.");
        //}
        //else
        //{
        //    Debug.Log("빈칸을 채워주세요.");
        //}
       


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

    private void Initialize()
    {
        m_idInputField.text = string.Empty;
        m_nameInputField.text = string.Empty;
        m_phoneNumInputField.text = string.Empty;
        m_positionXInputField.text = "0";
        m_positionYInputField.text = "0";
        m_positionZInputField.text = "0";
        m_rotationXInputField.text = "0";
        m_rotationYInputField.text = "0";
        m_rotationZInputField.text = "0";
    }

    private void UpdateUI(User_Gon user)
    {
        Initialize();

        if (user != null)
        {
            m_idInputField.text = user.ID.ToString();
            m_nameInputField.text = user.Name;
            m_phoneNumInputField.text = user.PhoneNumber;
            m_positionXInputField.text = user.Position.x.ToString();
            m_positionYInputField.text = user.Position.y.ToString();
            m_positionZInputField.text = user.Position.z.ToString();
            m_rotationXInputField.text = user.Rotation.x.ToString();
            m_rotationYInputField.text = user.Rotation.y.ToString();
            m_rotationZInputField.text = user.Rotation.z.ToString();
        }
    }

    private void Apply(User_Gon user)
    {
        if (user == null)
        {
            Debug.Log("선택된 User가 없습니다.");
            return;
        }

        user.Name = m_nameInputField.text;

        //var phone1 = m_phoneNumInputField.text.Substring(0, 3);
        //var phone2 = m_phoneNumInputField.text.Substring(3, 4);
        //var phone3 = m_phoneNumInputField.text.Substring(7, 4);
        //var phone_total = phone1 + "-" + phone2 + "-" + phone3;
        user.PhoneNumber = m_phoneNumInputField.text;

        if (string.IsNullOrEmpty(m_positionXInputField.text) == false &&
            string.IsNullOrEmpty(m_positionYInputField.text) == false &&
            string.IsNullOrEmpty(m_positionZInputField.text) == false)
        {
            var position = user.Position;
            position.x = float.Parse(m_positionXInputField.text);
            position.y = float.Parse(m_positionYInputField.text);
            position.z = float.Parse(m_positionZInputField.text);
            user.Position = position;
        }

        if (string.IsNullOrEmpty(m_rotationXInputField.text) == false &&
            string.IsNullOrEmpty(m_rotationYInputField.text) == false &&
            string.IsNullOrEmpty(m_rotationZInputField.text) == false)
        {
            var rotation = user.Rotation;
            rotation.x = float.Parse(m_rotationXInputField.text);
            rotation.y = float.Parse(m_rotationYInputField.text);
            rotation.z = float.Parse(m_rotationZInputField.text);
            user.Rotation = rotation;
        }

        var userObject = userObjectList.Find(uo => uo.Data.ID == user.ID);
        if (userObject != null)
            userObject.OnPropertyChanged();
    }

    private bool Exists(uint id)
    {
        if (userObjectList != null &&
            userObjectList.Count > 0)
        {
            return userObjectList.Exists(userObject => userObject.Data.ID == id);
        }
        return false;
    }

    public void OnSelectedUserChanged(int index)
    {
        var selectedID = uint.Parse(m_userDropdown.options[index].text);
        var selectedUserObject = userObjectList.Find(userObject => userObject.Data.ID == selectedID);
        if (selectedUserObject != null)
        {
            m_selectedUserObject = selectedUserObject;
            UpdateUI(selectedUserObject.Data);
        }
    }

    public void ModifyBtn()  // 수정버튼
    {
        var selectedUserObject = m_selectedUserObject;
        if (selectedUserObject != null)
        {
            Apply(selectedUserObject.Data);
            Debug.Log("수정되었습니다.");
        }
    }


    //public void DuplicateCheck() //중복체크 → 존재할때만 보여줌
    //{        
    //    if(userList.Count != 0)
    //    {
    //        for (int i = 0; i < userList.Count; ++i)// 생성된 user를 전부 검사
    //        {
    //            if (userList[i].ID == uint.Parse(m_idInputField.text))  // 생성되어져 있는 user와 현재 inputfield에 작성한 값이 같은지 확인
    //            {
    //                Debug.Log("이미 존재하는 ID 입니다.");
    //            }
    //        }
    //        for (int i = 0; i < userList.Count; ++i)// 생성된 user를 전부 검사
    //        {
    //            if (userList[i].ID != uint.Parse(m_idInputField.text))  // 생성되어져 있는 user와 현재 inputfield에 작성한 값이 같은지 확인
    //            {
    //                Debug.Log("사용 가능한 ID 입니다.");
    //                isDuplicateCheck = true;
    //            }
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("사용 가능한 ID 입니다.");
    //        isDuplicateCheck = true;
    //    }

    //}






    public void DeleteBtn() // ID 삭제버튼
    {
        var selectedUserObject = m_selectedUserObject;
        if (selectedUserObject != null)
        {
            userObjectList.Remove(selectedUserObject);
            Destroy(selectedUserObject.gameObject);

            var selectedIndex = m_userDropdown.options.FindIndex(optionData => optionData.text == selectedUserObject.Data.ID.ToString());
            if (selectedIndex >= 0)
            {
                m_userDropdown.options.RemoveAt(selectedIndex);

                var optionCount = m_userDropdown.options.Count;
                if (optionCount > 0)
                {
                    var lastIndex = optionCount - 1;
                    var selectedID = uint.Parse(m_userDropdown.options[lastIndex].text);
                    selectedUserObject = userObjectList.Find(userObject => userObject.Data.ID == selectedID);
                    if (selectedUserObject != null)
                    {
                        m_selectedUserObject = selectedUserObject;
                        UpdateUI(selectedUserObject.Data);
                    }
                    m_userDropdown.SetValueWithoutNotify(lastIndex);
                }
                else
                {
                    Initialize();
                    m_userDropdown.SetValueWithoutNotify(0);
                }

                m_userDropdown.RefreshShownValue();
                return;
            }
        }

        Debug.Log("삭제할 User가 존재하지 않습니다.");

        //if (userList.Count != 0)
        //{
        //    if (isDeleteImage == true) // 수정ID Image 켜기
        //    {
        //        deleteImage.SetActive(true);
        //        isDeleteImage = false;
        //    }
        //    else // 수정ID Image 끄기
        //    {
        //        deleteImage.SetActive(false);
        //        isDeleteImage = true;
        //    }

        //    for (int i = 0; i < userList.Count; i++)
        //    {
        //        if (userList[i].ID == uint.Parse(m_deleteInputField.text))
        //        {
        //            Destroy(userList[i].gameObject);
        //            userList.RemoveAt(i);
        //            deleteImage.SetActive(false);
        //        }
        //    }
        //    m_deleteInputField.text = "";
        //}
        //else
        //{
        //    Debug.Log("삭제할 User가 존재하지 않습니다.");
        //}

    }

    

    //public void OnIDChanged(string text)
    //{
    //    if (uint.TryParse(text, out var value))
    //        m_user.ID = value;
    //    m_idInputField.text = m_user.ID.ToString();
    //}

    //public void OnNameChanged(string text)
    //{
    //    m_user.Name = text;
    //}

    //public void OnPhoneNumberChanged(string text)
    //{
    //    m_user.PhoneNumber = text;
    //}

    //public void OnPositionXChanged(string text)
    //{
    //    var position = m_user.Position;
    //    position.x = float.Parse(text);
    //    m_user.Position = position;
    //    m_positionXInputField.text = m_user.Position.x.ToString();
    //}

    //public void OnPositionYChanged(string text)
    //{
    //    var position = m_user.Position;
    //    position.y = float.Parse(text);
    //    m_user.Position = position;
    //    m_positionYInputField.text = m_user.Position.y.ToString();
    //}

    //public void OnPositionZChanged(string text)
    //{
    //    var positon = m_user.Position;
    //    positon.z = float.Parse(text);
    //    m_user.Position = positon;
    //    m_positionZInputField.text = m_user.Position.z.ToString();
    //}

    //public void OnRotationXChanged(string text)
    //{
    //    var rotation = m_user.Rotation;
    //    rotation.x = float.Parse(text);
    //    m_user.Rotation = rotation;
    //    m_rotationXInputField.text = m_user.Rotation.x.ToString();
    //}

    //public void OnRotationYChanged(string text)
    //{
    //    var rotation = m_user.Rotation;
    //    rotation.y = float.Parse(text);
    //    m_user.Rotation = rotation;
    //    m_rotationYInputField.text = m_user.Rotation.y.ToString();
    //}

    //public void OnRotationZChanged(string text)
    //{
    //    var rotation = m_user.Rotation;
    //    rotation.z = float.Parse(text);
    //    m_user.Rotation = rotation;
    //    m_rotationZInputField.text = m_user.Rotation.z.ToString();
    //}

   
}
