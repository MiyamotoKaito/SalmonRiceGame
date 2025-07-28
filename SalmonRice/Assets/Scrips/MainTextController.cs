using NovelGame;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEditor.Search;
using UnityEngine;

public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;
    void Start()
    {
        //�ŏ��̍s�̃e�L�X�g��\���A�܂��͖��߂����s
        string statement = GamaManager.Instance.userManager.GetCurrentSentence();
        if (GamaManager.Instance.userManager.IsStatement(statement))
        {
            GamaManager.Instance.userManager.ExecuteStatement(statement);
            GoToNextLine();
        }
        DisPlayText();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GoToNextLine();
            DisPlayText();
        }
    }
    /// <summary>
    /// ���̍s�Ɉړ�
    /// </summary>
    public void GoToNextLine()
    {
        GamaManager.Instance.lineNumber++;
        string sectence = GamaManager.Instance.userManager.GetCurrentSentence();
        if (GamaManager.Instance.userManager.IsStatement(sectence))
        {
            GamaManager.Instance.userManager.ExecuteStatement(sectence);
            GoToNextLine();
        }
    }
    /// <summary>
    /// �e�L�X�g�\��
    /// </summary>
    public void DisPlayText()
    {
        string sentence = GamaManager.Instance.userManager.GetCurrentSentence();
        _mainTextObject.text = sentence;
    }
}
