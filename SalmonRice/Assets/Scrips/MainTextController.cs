using NovelGame;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;
    void Start()
    {
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
